namespace B1Profile
{
	public static partial class Helpers
	{
		public static short Swap(this short value)
		{
			return (short)((ushort)value).Swap();
		}

		public static ushort Swap(this ushort value)
		{
			return (ushort)((0x00FFu) & (value >> 8) |
							(0xFF00u) & (value << 8));
		}

		public static int Swap(this int value)
		{
			return (int)((uint)value).Swap();
		}

		public static uint Swap(this uint value)
		{
			return ((0x000000FFu) & (value >> 24) |
					(0x0000FF00u) & (value >> 8) |
					(0x00FF0000u) & (value << 8) |
					(0xFF000000u) & (value << 24));
		}

		public static long Swap(this long value)
		{
			return (long)((ulong)value).Swap();
		}

		public static ulong Swap(this ulong value)
		{
			return ((0x00000000000000FFu) & (value >> 56) |
					(0x000000000000FF00u) & (value >> 40) |
					(0x0000000000FF0000u) & (value >> 24) |
					(0x00000000FF000000u) & (value >> 8) |
					(0x000000FF00000000u) & (value << 8) |
					(0x0000FF0000000000u) & (value << 24) |
					(0x00FF000000000000u) & (value << 40) |
					(0xFF00000000000000u) & (value << 56));
		}
	}
}
