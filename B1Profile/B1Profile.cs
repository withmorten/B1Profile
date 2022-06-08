using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using PackageIO;

namespace B1Profile
{
    public enum DataType
    {
        Int32 = 1,
        String = 4,
        Single = 5,
        Binary = 6,
        Int8 = 8
    }

	unsafe public struct Entry
    {
        public uint ID;
        public uint Length;

		public long Offset;

		public byte StartByte;
		public byte EndByte;

        public DataType DataType;

        public byte[] Bin;
        public string String;
		public int Int32;
		public float Single;
		public byte Int8;

		public void SetBinData(byte[] bin)
		{
			if (DataType == DataType.Binary)
			{
				Bin = bin;
				Length = (uint)bin.Length;

				return;
			}

			throw new Exception("Entry with ID " + ID + " is not a Binary entry!");
		}

		public void SetStringData(string str)
		{
			if (DataType == DataType.String)
			{
				String = str;
				Length = (uint)str.Length;

				return;
			}

			throw new Exception("Entry with ID " + ID + " is not a String entry!");
		}

		public void SetInt32Data(int int32)
		{
			if (DataType == DataType.Int32)
			{
				Int32 = int32;

				return;
			}

			throw new Exception("Entry with ID " + ID + " is not an Int32 entry!");
		}

		public void SetSingleData(float single)
		{
			if (DataType == DataType.Single)
			{
				Single = single;

				return;
			}

			throw new Exception("Entry with ID " + ID + " is not a Single entry!");
		}

		public void SetInt8Data(int int8)
		{
			if (DataType == DataType.Int8)
			{
				Int32 = int8;

				return;
			}

			throw new Exception("Entry with ID " + ID + " is not an Int8 entry!");
		}

		public byte[] GetBinData()
		{
			if (DataType == DataType.Binary)
			{
				return Bin;
			}

			throw new Exception("Entry with ID " + ID + " is not a Binary entry!");
		}

		public string GetStringData()
		{
			if (DataType == DataType.String)
			{
				return String;
			}

			throw new Exception("Entry with ID " + ID + " is not a String entry!");
		}

		public int GetInt32Data()
		{
			if (DataType == DataType.Int32)
			{
				return Int32;
			}

			throw new Exception("Entry with ID " + ID + " is not an Int32 entry!");
		}

		public float GetSingleData()
		{
			if (DataType == DataType.Single)
			{
				return Single;
			}

			throw new Exception("Entry with ID " + ID + " is not a Single entry!");
		}

		public byte GetInt8Data()
		{
			if (DataType == DataType.Int8)
			{
				return Int8;
			}

			throw new Exception("Entry with ID " + ID + " is not an Int8 entry!");
		}
    }

	public class Profile
	{
		public enum EntryID : uint
		{
			NumProfileSaved = 27, // Int32
			FOV = 129, // Int32
			NumGoldenKeys = 130, // Int32
			NumGoldenKeysUsed = 131, // Int32
		}

		private Entry[] Entries;

		public const int MaxGoldenKeys = 999;
		public const int MaxGoldenKeysTotal = MaxGoldenKeys;

		public int NumGoldenKeys;
		public int NumGoldenKeysUsed;

		public Profile()
		{
			Array.Resize(ref Entries, 0);
		}

		public Profile(string path, bool dumpUncompressed = false) : this()
		{
			Load(path, dumpUncompressed);
		}

		public bool Load(string path, bool dumpUncompressed = false)
		{
			// open input file
			FileStream inputFile = File.OpenRead(path); // TODO exception handling
			BinaryReader inputFileStream = new BinaryReader(inputFile);

			// read SHA1 hash into nothing
			inputFileStream.ReadBytes(20);

			// prepare uncompressed data
			uint uncompressedSize = inputFileStream.ReadUInt32().Swap(); // bswap for Big Endian
			byte[] uncompressedBytes = new byte[uncompressedSize];

			// read the compressed data
			uint compressedSize = (uint)inputFile.Length - 20 - sizeof(uint);
			byte[] compressedBytes = inputFileStream.ReadBytes((int)compressedSize);

			// and close the inptut file, no longer needed at this point
			inputFileStream.Close();

			// decompress the data
			int actualUncompressedSize = (int)uncompressedSize;
			MiniLZO.ErrorCode result = MiniLZO.LZO.DecompressSafe(compressedBytes, 0, (int)compressedSize, uncompressedBytes, 0, ref actualUncompressedSize);

			if (result != MiniLZO.ErrorCode.Success)
			{
				Console.WriteLine("error: couldn't decompress " + path);

				return false;
			}

			// dump the file for debugging purposes
			if (dumpUncompressed == true)
			{
				FileStream decompressedFile = File.Create(path + ".bak.dat");
				decompressedFile.Write(uncompressedBytes, 0, (int)uncompressedSize);
				decompressedFile.Close();
			}

			// parse the entries
			LoadEntries(new Reader(new MemoryStream(uncompressedBytes), Endian.Big));

			// and store the relevant data in our class
			LoadEntryData();

			return true;
		}

		public bool Save(string path, bool dumpUncompressed = false)
		{
			// for security reasons, create a backup of the file before saving
			File.Copy(path, path + ".bak", true);

			// add our class data back to the entries
			SaveEntryData();

			// store entries and prepare the uncompressed data
			MemoryStream uncompressedStream = new MemoryStream();
			SaveEntries(new Writer(uncompressedStream, Endian.Big));

			// dump the file for debugging purposes
			if (dumpUncompressed == true)
			{
				FileStream uncompressedFile = File.Create(path + ".dat");
				uncompressedFile.Write(uncompressedStream.ToArray(), 0, (int)uncompressedStream.Length);
				uncompressedFile.Close();
			}

			// prepare the compressed data
			byte[] compressedBytes = new byte[uncompressedStream.Length];
			int actualCompressedLength = (int)uncompressedStream.Length;

			// LZO compress the data
			MiniLZO.LZO.Compress(uncompressedStream.ToArray(), 0, (int)uncompressedStream.Length, compressedBytes, 0, ref actualCompressedLength, new MiniLZO.CompressWorkBuffer());

			// prepare the hashed data (length + compressed data)
			int actualUncompressedLength = (int)uncompressedStream.Length;
			byte[] hashedData = BitConverter.GetBytes(actualUncompressedLength.Swap()); // bswap for Big Endian
			Array.Resize(ref hashedData, 4 + actualCompressedLength);
			Array.Copy(compressedBytes, 0, hashedData, 4, actualCompressedLength);

			// hash the data
			SHA1Managed sha1 = new SHA1Managed();
			byte[] hash = sha1.ComputeHash(hashedData);

			// create output file and writer
			FileStream outputFile = File.Create(path); // TODO exception handling
			BinaryWriter outputFileStream = new BinaryWriter(outputFile);

			// write SHA1 hash and hashed data
			outputFileStream.Write(hash);
			outputFileStream.Write(hashedData);

			// and close the file
			outputFileStream.Close();

			return true;
		}

		public ref Entry GetEntry(uint ID)
		{
			for (int i = 0; i < Entries.Length; i++)
			{
				if (Entries[i].ID == ID) return ref Entries[i];
			}

			throw new Exception("Entry with ID " + ID + " not found!");
		}

		public ref Entry GetEntry(EntryID ID)
		{
			return ref GetEntry(((uint)ID));
		}

		private void LoadEntries(Reader reader)
		{
			uint numEntries = reader.ReadUInt32();

			Array.Resize(ref Entries, (int)numEntries);

			for (uint i = 0; i < numEntries; i++)
			{

				Entries[i].StartByte = reader.ReadByte();

				Entries[i].ID = reader.ReadUInt32();
				Entries[i].DataType = (DataType)reader.ReadByte();

				Entries[i].Offset = reader.Position;

				switch (Entries[i].DataType)
				{
				case DataType.Int32:
					Entries[i].Int32 = reader.ReadInt32();

					break;
				case DataType.String:
					Entries[i].Length = reader.ReadUInt32();
					Entries[i].String = reader.ReadASCII((int)Entries[i].Length);

					break;
				case DataType.Single:
					Entries[i].Single = reader.ReadSingle();

					break;
				case DataType.Binary:
					Entries[i].Length = reader.ReadUInt32();
					Entries[i].Bin = reader.ReadBytes((int)Entries[i].Length, Endian.Little);

					break;
				case DataType.Int8:
					Entries[i].Int8 = reader.ReadByte();

					break;
				}

				Entries[i].EndByte = reader.ReadByte();
			}
		}

		private void SaveEntries(Writer writer)
		{
			writer.WriteUInt32((uint)Entries.Length);

			for (int i = 0; i < Entries.Length; i++)
			{
				writer.WriteByte(Entries[i].StartByte);

				writer.WriteUInt32(Entries[i].ID);
				writer.WriteByte((byte)Entries[i].DataType);

				switch (Entries[i].DataType)
				{
				case DataType.Int32:
					writer.WriteInt32(Entries[i].Int32);

					break;
				case DataType.String:
					writer.WriteUInt32(Entries[i].Length);
					writer.WriteASCII(Entries[i].String, (int)Entries[i].Length);

					break;
				case DataType.Single:
					writer.WriteSingle(Entries[i].Single);

					break;
				case DataType.Binary:
					writer.WriteUInt32(Entries[i].Length);
					writer.WriteBytes(Entries[i].Bin, (int)Entries[i].Length, Endian.Little);

					break;
				case DataType.Int8:
					writer.WriteByte(Entries[i].Int8);

					break;
				}

				writer.WriteByte(Entries[i].EndByte);
			}
		}

		public void PrintEntries()
		{
			Console.WriteLine("numEntries: " + Entries.Length);
			Console.WriteLine();

			for (int i = 0; i < Entries.Length; i++)
			{
				Console.WriteLine("Entry nr: " + i);
				Console.WriteLine("Position: " + Entries[i].Offset);

				Console.Write("ID: " + Entries[i].ID);

				if (Enum.IsDefined(typeof(EntryID), Entries[i].ID))
				{
					Console.Write(" (" + Enum.GetName(typeof(EntryID), Entries[i].ID) + ")");
				}

				Console.WriteLine();

				Console.WriteLine("DataType: " + Entries[i].DataType.ToString());

				switch (Entries[i].DataType)
				{
				case DataType.Int32:
					Console.WriteLine("Value: " + Entries[i].Int32);

					break;
				case DataType.String:
					Console.WriteLine("Value: " + Entries[i].String);

					break;
				case DataType.Single:
					Console.WriteLine("Value: " + Entries[i].Single);

					break;
				case DataType.Binary:
					Console.Write("Value:");

					for (int j = 0; j < Entries[i].Length; j++)
					{
						Console.Write(" " + Entries[i].Bin[j]);
					}

					Console.WriteLine();

					break;
				case DataType.Int8:
					Console.WriteLine("Value: " + Entries[i].Int8);

					break;
				}

				Console.WriteLine();
			}
		}

		private unsafe void LoadEntryData()
		{
			NumGoldenKeys = GetEntry(EntryID.NumGoldenKeys).GetInt32Data();
			NumGoldenKeysUsed = GetEntry(EntryID.NumGoldenKeysUsed).GetInt32Data();
		}

		private unsafe void SaveEntryData()
		{
			GetEntry(EntryID.NumGoldenKeys).SetInt32Data(NumGoldenKeys);
			GetEntry(EntryID.NumGoldenKeysUsed).SetInt32Data(NumGoldenKeysUsed);
		}
	}
}
