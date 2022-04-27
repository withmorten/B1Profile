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

			// Dump some data before editing ...
#if false
			Console.WriteLine("Input:");
			Console.WriteLine();

			Console.WriteLine("Golden Keys POPremierClub Valid: " + profile.GetGoldenKeysPOPremierClubEntry().IsValid());
			Console.WriteLine("Golden Keys POPremierClub NumKeys: " + profile.GetGoldenKeysPOPremierClubEntry().GetNumKeys());
			Console.WriteLine("Golden Keys POPremierClub NumKeysUsed: " + profile.GetGoldenKeysPOPremierClubEntry().GetNumKeysUsed());
			Console.WriteLine();

			Console.WriteLine("Golden Keys Tulip Valid: " + profile.GetGoldenKeysTulipEntry().IsValid());
			Console.WriteLine("Golden Keys Tulip NumKeys: " + profile.GetGoldenKeysTulipEntry().GetNumKeys());
			Console.WriteLine("Golden Keys Tulip NumKeysUsed: " + profile.GetGoldenKeysTulipEntry().GetNumKeysUsed());
			Console.WriteLine();

			Console.WriteLine("Golden Keys SHiFT Valid: " + profile.GetGoldenKeysShiftEntry().IsValid());
			Console.WriteLine("Golden Keys SHiFT NumKeys: " + profile.GetGoldenKeysShiftEntry().GetNumKeys());
			Console.WriteLine("Golden Keys SHiFT NumKeysUsed: " + profile.GetGoldenKeysShiftEntry().GetNumKeysUsed());
			Console.WriteLine();

			Console.WriteLine("Badass Rank: " + profile.GetBadassRank());
			Console.WriteLine("Badass Tokens: " + profile.GetBadassTokensAvailable());
			Console.WriteLine("Earned Badass Tokens: " + profile.GetBadassTokensEarned());
			Console.WriteLine();

			Console.WriteLine("Bonus Maximum Health: " + profile.GetMaximumHealthBonus());
			Console.WriteLine("Bonus Shield Capacity: " + profile.GetShieldCapacityBonus());
			Console.WriteLine("Bonus Shield Recharge Delay: " + profile.GetShieldRechargeDelayBonus());
			Console.WriteLine("Bonus Shield Recharge Rate: " + profile.GetShieldRechargeRateBonus());
			Console.WriteLine("Bonus Melee Damage: " + profile.GetMeleeDamageBonus());
			Console.WriteLine("Bonus Grenade Damage: " + profile.GetGrenadeDamageBonus());
			Console.WriteLine("Bonus Gun Accuracy: " + profile.GetGunAccuracyBonus());
			Console.WriteLine("Bonus Gun Damage: " + profile.GetGunDamageBonus());
			Console.WriteLine("Bonus Fire Rate: " + profile.GetFireRateBonus());
			Console.WriteLine("Bonus Recoil Reduction: " + profile.GetRecoilReductionBonus());
			Console.WriteLine("Bonus Reload Speed: " + profile.GetReloadSpeedBonus());
			Console.WriteLine("Bonus Elemental Effect Chance: " + profile.GetElementalEffectChanceBonus());
			Console.WriteLine("Bonus Elemental Effect Damage: " + profile.GetElementalEffectDamageBonus());
			Console.WriteLine("Bonus Critical Hit Damage: " + profile.GetCriticalHitDamageBonus());
#endif

			// Set all key entries to max (765 keys total)
#if false
			profile.GetGoldenKeysPOPremierClubEntry().SetNumKeys(255);
			profile.GetGoldenKeysPOPremierClubEntry().SetNumKeysUsed(0);

			profile.GetGoldenKeysTulipEntry().SetNumKeys(255);
			profile.GetGoldenKeysTulipEntry().SetNumKeysUsed(0);

			profile.GetGoldenKeysShiftEntry().SetNumKeys(255);
			profile.GetGoldenKeysShiftEntry().SetNumKeysUsed(0);
#endif

			// Dump some data after editing ...
#if false
			Console.WriteLine();

			Console.WriteLine("Output:");
			Console.WriteLine();

			Console.WriteLine("Golden Keys POPremierClub Valid: " + profile.GetGoldenKeysPOPremierClubEntry().IsValid());
			Console.WriteLine("Golden Keys POPremierClub NumKeys: " + profile.GetGoldenKeysPOPremierClubEntry().GetNumKeys());
			Console.WriteLine("Golden Keys POPremierClub NumKeysUsed: " + profile.GetGoldenKeysPOPremierClubEntry().GetNumKeysUsed());
			Console.WriteLine();

			Console.WriteLine("Golden Keys Tulip Valid: " + profile.GetGoldenKeysTulipEntry().IsValid());
			Console.WriteLine("Golden Keys Tulip NumKeys: " + profile.GetGoldenKeysTulipEntry().GetNumKeys());
			Console.WriteLine("Golden Keys Tulip NumKeysUsed: " + profile.GetGoldenKeysTulipEntry().GetNumKeysUsed());
			Console.WriteLine();

			Console.WriteLine("Golden Keys SHiFT Valid: " + profile.GetGoldenKeysShiftEntry().IsValid());
			Console.WriteLine("Golden Keys SHiFT NumKeys: " + profile.GetGoldenKeysShiftEntry().GetNumKeys());
			Console.WriteLine("Golden Keys SHiFT NumKeysUsed: " + profile.GetGoldenKeysShiftEntry().GetNumKeysUsed());
			Console.WriteLine();

			Console.WriteLine("Badass Rank: " + profile.GetBadassRank());
			Console.WriteLine("Badass Tokens: " + profile.GetBadassTokens());
			Console.WriteLine("Earned Badass Tokens: " + profile.GetBadassTokensEarned());
			Console.WriteLine();

			Console.WriteLine("Bonus Maximum Health: " + profile.GetMaximumHealthBonus());
			Console.WriteLine("Bonus Shield Capacity: " + profile.GetShieldCapacityBonus());
			Console.WriteLine("Bonus Shield Recharge Delay: " + profile.GetShieldRechargeDelayBonus());
			Console.WriteLine("Bonus Shield Recharge Rate: " + profile.GetShieldRechargeRateBonus());
			Console.WriteLine("Bonus Melee Damage: " + profile.GetMeleeDamageBonus());
			Console.WriteLine("Bonus Grenade Damage: " + profile.GetGrenadeDamageBonus());
			Console.WriteLine("Bonus Gun Accuracy: " + profile.GetGunAccuracyBonus());
			Console.WriteLine("Bonus Gun Damage: " + profile.GetGunDamageBonus());
			Console.WriteLine("Bonus Fire Rate: " + profile.GetFireRateBonus());
			Console.WriteLine("Bonus Recoil Reduction: " + profile.GetRecoilReductionBonus());
			Console.WriteLine("Bonus Reload Speed: " + profile.GetReloadSpeedBonus());
			Console.WriteLine("Bonus Elemental Effect Chance: " + profile.GetElementalEffectChanceBonus());
			Console.WriteLine("Bonus Elemental Effect Damage: " + profile.GetElementalEffectDamageBonus());
			Console.WriteLine("Bonus Critical Hit Damage: " + profile.GetCriticalHitDamageBonus());
#endif

#if false
			Entry FOVEntry = profile.GetEntryFromID(129);

			FOVEntry.SetInt32Data(Int32.Parse(args[1]));
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
