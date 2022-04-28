using System;
using B1Profile;

namespace B1ProfileCMD
{
	class Program
	{
		static int Main(string[] args)
		{
			if (args.Length < 1) return 1;

			Profile profile = new Profile();

			if (profile.Load(args[0], true) == false)
			{
				Console.WriteLine("Error loading " + args[0]);

				return 1;
			}

			// Just some examples what you can do with this ...

			// default we just dump the profile.bin contents to stdout and exit
#if true
			profile.PrintEntries();

			return 0;
#endif

			// set golden keys to 666
#if false
			profile.NumGoldenKeys = 666;
#endif

			if (profile.Save("profile.bin", true) == false)
			{
				Console.WriteLine("Error saving profile.bin");

				return 1;
			}

			return 0;
		}
	}
}
