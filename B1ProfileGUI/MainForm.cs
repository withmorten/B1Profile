using System;
using System.Windows.Forms;
using System.Drawing;
using B1Profile;

namespace B1ProfileGUI
{
	public partial class MainForm : Form
	{
		private string ProfileFilePath;
		public bool ProfileDirty;

		public MainForm()
		{
			InitializeComponent();
		}

		public void TransferFromProfile()
		{
			BadassRankInput.Value = Program.Profile.GetBadassRank();
			BadassTokensEarnedInput.Value = Program.Profile.GetBadassTokensEarned();
			BadassTokensAvailableInput.Value = Program.Profile.GetBadassTokensAvailable();

			BadassTokensInvestedLabel.Text = Program.Profile.GetBadassTokensInvested().ToString();

			MaximumHealthBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.MaximumHealth);
			MaximumHealthBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.MaximumHealth);

			ShieldCapacityBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.ShieldCapacity);
			ShieldCapacityBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.ShieldCapacity);

			ShieldRechargeDelayBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.ShieldRechargeDelay);
			ShieldRechargeDelayBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.ShieldRechargeDelay);

			ShieldRechargeRateBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.ShieldRechargeRate);
			ShieldRechargeRateBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.ShieldRechargeRate);

			MeleeDamageBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.MeleeDamage);
			MeleeDamageBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.MeleeDamage);

			GrenadeDamageBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.GrenadeDamage);
			GrenadeDamageBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.GrenadeDamage);

			GunAccuracyBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.GunAccuracy);
			GunAccuracyBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.GunAccuracy);

			GunDamageBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.GunDamage);
			GunDamageBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.GunDamage);

			FireRateBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.FireRate);
			FireRateBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.FireRate);

			RecoilReductionBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.RecoilReduction);
			RecoilReductionBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.RecoilReduction);

			ReloadSpeedBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.ReloadSpeed);
			ReloadSpeedBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.ReloadSpeed);

			ElementalEffectChanceBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.ElementalEffectChance);
			ElementalEffectChanceBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.ElementalEffectChance);

			ElementalEffectDamageBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.ElementalEffectDamage);
			ElementalEffectDamageBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.ElementalEffectDamage);

			CriticalHitDamageBonusPercentInput.Value = (decimal)Program.Profile.GetBonusStatusBonus(Profile.BonusStat.CriticalHitDamage);
			CriticalHitDamageBonusTokensInput.Value = Program.Profile.GetBonusStatTokens(Profile.BonusStat.CriticalHitDamage);

			GoldenKeysTotalInput.Value
				= (GoldenKeysPOPremierClubInput.Value - GoldenKeysPOPremierClubUsedInput.Value)
				+ (GoldenKeysTulipInput.Value - GoldenKeysTulipUsedInput.Value)
				+ (GoldenKeysShiftInput.Value - GoldenKeysShiftUsedInput.Value);
		}

		public void TransferToProfile()
		{
			Program.Profile.SetBadassRank((int)BadassRankInput.Value);
			Program.Profile.SetBadassTokensEarned((int)BadassTokensEarnedInput.Value);
			Program.Profile.SetBadassTokensAvailable((int)BadassTokensAvailableInput.Value);

			Program.Profile.SetBonusStatTokens(Profile.BonusStat.MaximumHealth, (uint)MaximumHealthBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.ShieldCapacity, (uint)ShieldCapacityBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.ShieldRechargeDelay, (uint)ShieldRechargeDelayBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.ShieldRechargeRate, (uint)ShieldRechargeRateBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.MeleeDamage, (uint)MeleeDamageBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.GrenadeDamage, (uint)GrenadeDamageBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.GunAccuracy, (uint)GunAccuracyBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.GunDamage, (uint)GunDamageBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.FireRate, (uint)FireRateBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.RecoilReduction, (uint)RecoilReductionBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.ReloadSpeed, (uint)ReloadSpeedBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.ElementalEffectChance, (uint)ElementalEffectChanceBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.ElementalEffectDamage, (uint)ElementalEffectDamageBonusTokensInput.Value);
			Program.Profile.SetBonusStatTokens(Profile.BonusStat.CriticalHitDamage, (uint)CriticalHitDamageBonusTokensInput.Value);

			Program.Profile.GetGoldenKeysPOPremierClubEntry().SetNumKeys((byte)GoldenKeysPOPremierClubInput.Value);
			Program.Profile.GetGoldenKeysPOPremierClubEntry().SetNumKeysUsed((byte)GoldenKeysPOPremierClubUsedInput.Value);

			Program.Profile.GetGoldenKeysTulipEntry().SetNumKeys((byte)GoldenKeysTulipInput.Value);
			Program.Profile.GetGoldenKeysTulipEntry().SetNumKeysUsed((byte)GoldenKeysTulipUsedInput.Value);

			Program.Profile.GetGoldenKeysShiftEntry().SetNumKeys((byte)GoldenKeysShiftInput.Value);
			Program.Profile.GetGoldenKeysShiftEntry().SetNumKeysUsed((byte)GoldenKeysShiftUsedInput.Value);
		}

		private void TransferIgnoresToProfile()
		{
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.MaximumHealth, MaximumHealthIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.ShieldCapacity, ShieldCapacityIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.ShieldRechargeDelay, ShieldRechargeDelayIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.ShieldRechargeRate, ShieldRechargeRateIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.MeleeDamage, MeleeDamageIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.GrenadeDamage, GrenadeDamageIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.GunAccuracy, GunAccuracyIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.GunDamage, GunDamageIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.FireRate, FireRateIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.RecoilReduction, RecoilReductionIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.ReloadSpeed, ReloadSpeedIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.ElementalEffectChance, ElementalEffectChanceIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.ElementalEffectDamage, ElementalEffectDamageIgnoreCheckBox.Checked);
			Program.Profile.SetIgnoreBonusStat(Profile.BonusStat.CriticalHitDamage, CriticalHitDamageIgnoreCheckBox.Checked);
		}

		private void LoadProfile()
		{
			Program.Profile = new Profile(ProfileFilePath);

			TransferFromProfile();

			BadassRankInput.PrevValue = BadassRankInput.Value;
			BadassTokensEarnedInput.PrevValue = BadassTokensEarnedInput.Value;
			BadassTokensAvailableInput.PrevValue = BadassTokensAvailableInput.Value;

			MaximumHealthBonusTokensInput.PrevValue = MaximumHealthBonusTokensInput.Value;
			ShieldCapacityBonusTokensInput.PrevValue = ShieldCapacityBonusTokensInput.Value;
			ShieldRechargeDelayBonusTokensInput.PrevValue = ShieldRechargeDelayBonusTokensInput.Value;
			ShieldRechargeRateBonusTokensInput.PrevValue = ShieldRechargeRateBonusTokensInput.Value;
			MeleeDamageBonusTokensInput.PrevValue = MeleeDamageBonusTokensInput.Value;
			GrenadeDamageBonusTokensInput.PrevValue = GrenadeDamageBonusTokensInput.Value;
			GunAccuracyBonusTokensInput.PrevValue = GunAccuracyBonusTokensInput.Value;
			GunDamageBonusTokensInput.PrevValue = GunDamageBonusTokensInput.Value;
			FireRateBonusTokensInput.PrevValue = FireRateBonusTokensInput.Value;
			RecoilReductionBonusTokensInput.PrevValue = RecoilReductionBonusTokensInput.Value;
			ReloadSpeedBonusTokensInput.PrevValue = ReloadSpeedBonusTokensInput.Value;
			ElementalEffectChanceBonusTokensInput.PrevValue = ElementalEffectChanceBonusTokensInput.Value;
			ElementalEffectDamageBonusTokensInput.PrevValue = ElementalEffectDamageBonusTokensInput.Value;
			CriticalHitDamageBonusTokensInput.PrevValue = CriticalHitDamageBonusTokensInput.Value;

			GoldenKeysPOPremierClubInput.PrevValue = GoldenKeysPOPremierClubInput.Value;
			GoldenKeysPOPremierClubUsedInput.PrevValue = GoldenKeysPOPremierClubUsedInput.Value;

			GoldenKeysTulipInput.PrevValue = GoldenKeysTulipInput.Value;
			GoldenKeysTulipUsedInput.PrevValue = GoldenKeysTulipUsedInput.Value;

			GoldenKeysShiftInput.PrevValue = GoldenKeysShiftInput.Value;
			GoldenKeysShiftUsedInput.PrevValue = GoldenKeysShiftUsedInput.Value;
		}

		private void SaveProfile()
		{
			TransferToProfile();

			Program.Profile.Save(ProfileFilePath);

			ProfileDirty = false;

			MessageBox.Show("Profile saved!\r\n\r\nIf you want revert the changes, go to your SaveData directory and rename the profile.bin.bak generated by this tool to profile.bin!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void EnableGUI()
		{
			MainMenuSaveButton.Enabled = true;

			UnlockAllCustomizationsButton.Enabled = true;
			LockAllCustomizationsButton.Enabled = true;

			ResetBonusStatsButton.Enabled = true;
			EvenlyDistributeTokensButton.Enabled = true;

			BadassRankInput.Enabled = true;
			BadassTokensAvailableInput.Enabled = true;
			BadassTokensEarnedInput.Enabled = true;

			SyncedModeCheckBox.Enabled = true;

			BadassTokensInvestedLabel.ForeColor = SystemColors.ControlText;

			MaximumHealthBonusPercentInput.Enabled = true;
			ShieldCapacityBonusPercentInput.Enabled = true;
			ShieldRechargeDelayBonusPercentInput.Enabled = true;
			ShieldRechargeRateBonusPercentInput.Enabled = true;
			MeleeDamageBonusPercentInput.Enabled = true;
			GrenadeDamageBonusPercentInput.Enabled = true;
			GunAccuracyBonusPercentInput.Enabled = true;
			GunDamageBonusPercentInput.Enabled = true;
			FireRateBonusPercentInput.Enabled = true;
			RecoilReductionBonusPercentInput.Enabled = true;
			ReloadSpeedBonusPercentInput.Enabled = true;
			ElementalEffectChanceBonusPercentInput.Enabled = true;
			ElementalEffectDamageBonusPercentInput.Enabled = true;
			CriticalHitDamageBonusPercentInput.Enabled = true;

			MaximumHealthBonusTokensInput.Enabled = true;
			ShieldCapacityBonusTokensInput.Enabled = true;
			ShieldRechargeDelayBonusTokensInput.Enabled = true;
			ShieldRechargeRateBonusTokensInput.Enabled = true;
			MeleeDamageBonusTokensInput.Enabled = true;
			GrenadeDamageBonusTokensInput.Enabled = true;
			GunAccuracyBonusTokensInput.Enabled = true;
			GunDamageBonusTokensInput.Enabled = true;
			FireRateBonusTokensInput.Enabled = true;
			RecoilReductionBonusTokensInput.Enabled = true;
			ReloadSpeedBonusTokensInput.Enabled = true;
			ElementalEffectChanceBonusTokensInput.Enabled = true;
			ElementalEffectDamageBonusTokensInput.Enabled = true;
			CriticalHitDamageBonusTokensInput.Enabled = true;

			MaximumHealthIgnoreCheckBox.Enabled = true;
			ShieldCapacityIgnoreCheckBox.Enabled = true;
			ShieldRechargeDelayIgnoreCheckBox.Enabled = true;
			ShieldRechargeRateIgnoreCheckBox.Enabled = true;
			MeleeDamageIgnoreCheckBox.Enabled = true;
			GrenadeDamageIgnoreCheckBox.Enabled = true;
			GunAccuracyIgnoreCheckBox.Enabled = true;
			GunDamageIgnoreCheckBox.Enabled = true;
			FireRateIgnoreCheckBox.Enabled = true;
			RecoilReductionIgnoreCheckBox.Enabled = true;
			ReloadSpeedIgnoreCheckBox.Enabled = true;
			ElementalEffectChanceIgnoreCheckBox.Enabled = true;
			ElementalEffectDamageIgnoreCheckBox.Enabled = true;
			CriticalHitDamageIgnoreCheckBox.Enabled = true;

			GoldenKeysTulipInput.Enabled = true;
			GoldenKeysTulipUsedInput.Enabled = true;

			GoldenKeysShiftInput.Enabled = true;
			GoldenKeysShiftUsedInput.Enabled = true;

			GoldenKeysPOPremierClubInput.Enabled = true;
			GoldenKeysPOPremierClubUsedInput.Enabled = true;

			GoldenKeysTotalInput.Enabled = true;

			MaxGoldenKeysButton.Enabled = true;

			if (Program.Profile.IsClaptrapsStashSlotValid(1) == true) CopySlot1CodeButton.Enabled = true;
			if (Program.Profile.IsClaptrapsStashSlotValid(2) == true) CopySlot2CodeButton.Enabled = true;
			if (Program.Profile.IsClaptrapsStashSlotValid(3) == true) CopySlot3CodeButton.Enabled = true;
			if (Program.Profile.IsClaptrapsStashSlotValid(4) == true) CopySlot4CodeButton.Enabled = true;

			PasteSlot1CodeButton.Enabled = true;
			PasteSlot2CodeButton.Enabled = true;
			PasteSlot3CodeButton.Enabled = true;
			PasteSlot4CodeButton.Enabled = true;

			if (Program.Profile.IsClaptrapsStashSlotValid(1) == true) DeleteSlot1Button.Enabled = true;
			if (Program.Profile.IsClaptrapsStashSlotValid(2) == true) DeleteSlot2Button.Enabled = true;
			if (Program.Profile.IsClaptrapsStashSlotValid(3) == true) DeleteSlot3Button.Enabled = true;
			if (Program.Profile.IsClaptrapsStashSlotValid(4) == true) DeleteSlot4Button.Enabled = true;
		}

		public void UpdateBadassTokensInvested(decimal inc)
		{
			decimal t = Decimal.Parse(BadassTokensInvestedLabel.Text);

			t += inc;

			BadassTokensInvestedLabel.Text = t.ToString();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.O))
			{
				MainMenuOpenButton_Click(null, null);

				return true;
			}
			else if (keyData == (Keys.Control | Keys.S))
			{
				if (MainMenuSaveButton.Enabled == true)
				{
					MainMenuSaveButton_Click(null, null);

					return true;
				}

				return false;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Program.MainForm = this;
			Program.Profile = null;
			ProfileFilePath = null;
			ProfileDirty = false;

			MaximumHealthBonusPercentInput.TokenUpDown = MaximumHealthBonusTokensInput;
			MaximumHealthBonusTokensInput.PercentUpDown = MaximumHealthBonusPercentInput;

			ShieldCapacityBonusPercentInput.TokenUpDown = ShieldCapacityBonusTokensInput;
			ShieldCapacityBonusTokensInput.PercentUpDown = ShieldCapacityBonusPercentInput;

			ShieldRechargeDelayBonusPercentInput.TokenUpDown = ShieldRechargeDelayBonusTokensInput;
			ShieldRechargeDelayBonusTokensInput.PercentUpDown = ShieldRechargeDelayBonusPercentInput;

			ShieldRechargeRateBonusPercentInput.TokenUpDown = ShieldRechargeRateBonusTokensInput;
			ShieldRechargeRateBonusTokensInput.PercentUpDown = ShieldRechargeRateBonusPercentInput;

			MeleeDamageBonusPercentInput.TokenUpDown = MeleeDamageBonusTokensInput;
			MeleeDamageBonusTokensInput.PercentUpDown = MeleeDamageBonusPercentInput;

			GrenadeDamageBonusPercentInput.TokenUpDown = GrenadeDamageBonusTokensInput;
			GrenadeDamageBonusTokensInput.PercentUpDown = GrenadeDamageBonusPercentInput;

			GunAccuracyBonusPercentInput.TokenUpDown = GunAccuracyBonusTokensInput;
			GunAccuracyBonusTokensInput.PercentUpDown = GunAccuracyBonusPercentInput;

			GunDamageBonusPercentInput.TokenUpDown = GunDamageBonusTokensInput;
			GunDamageBonusTokensInput.PercentUpDown = GunDamageBonusPercentInput;

			FireRateBonusPercentInput.TokenUpDown = FireRateBonusTokensInput;
			FireRateBonusTokensInput.PercentUpDown = FireRateBonusPercentInput;

			RecoilReductionBonusPercentInput.TokenUpDown = RecoilReductionBonusTokensInput;
			RecoilReductionBonusTokensInput.PercentUpDown = RecoilReductionBonusPercentInput;

			ReloadSpeedBonusPercentInput.TokenUpDown = ReloadSpeedBonusTokensInput;
			ReloadSpeedBonusTokensInput.PercentUpDown = ReloadSpeedBonusPercentInput;

			ElementalEffectChanceBonusPercentInput.TokenUpDown = ElementalEffectChanceBonusTokensInput;
			ElementalEffectChanceBonusTokensInput.PercentUpDown = ElementalEffectChanceBonusPercentInput;

			ElementalEffectDamageBonusPercentInput.TokenUpDown = ElementalEffectDamageBonusTokensInput;
			ElementalEffectDamageBonusTokensInput.PercentUpDown = ElementalEffectDamageBonusPercentInput;

			CriticalHitDamageBonusPercentInput.TokenUpDown = CriticalHitDamageBonusTokensInput;
			CriticalHitDamageBonusTokensInput.PercentUpDown = CriticalHitDamageBonusPercentInput;

			GoldenKeysPOPremierClubInput.KeysUsedUpDown = GoldenKeysPOPremierClubUsedInput;
			GoldenKeysPOPremierClubUsedInput.KeysUpDown = GoldenKeysPOPremierClubInput;

			GoldenKeysTulipInput.KeysUsedUpDown = GoldenKeysTulipUsedInput;
			GoldenKeysTulipUsedInput.KeysUpDown = GoldenKeysTulipInput;

			GoldenKeysShiftInput.KeysUsedUpDown = GoldenKeysShiftUsedInput;
			GoldenKeysShiftUsedInput.KeysUpDown = GoldenKeysShiftInput;

			RandomQuoteLabel.Text = GetRandomQuote();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Program.Profile != null && ProfileDirty == true)
			{
				switch (MessageBox.Show("A profile is loaded, do you want to save it?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
				case DialogResult.Yes:
					SaveProfile();

					Program.Profile = null;

					break;

				case DialogResult.No:
					Program.Profile = null;

					break;

				case DialogResult.Cancel:
					e.Cancel = true;

					break;
				}
			}
		}

		private void MainMenuOpenButton_Click(object sender, EventArgs e)
		{
			if (Program.Profile != null && ProfileDirty == true)
			{
				switch (MessageBox.Show("A profile is loaded, do you want to save it?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
				{
				case DialogResult.Yes:
					SaveProfile();

					Program.Profile = null;

					break;

				case DialogResult.No:
					Program.Profile = null;

					break;

				case DialogResult.Cancel:
					return;

					break;
				}
			}

			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Title = "Select BL2 profile";
			openFileDialog.Filter = "BL2 profile|*.bin";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Borderlands 2\\WillowGame\\SaveData";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ProfileFilePath = openFileDialog.FileName;

				LoadProfile();

				EnableGUI();
			}
		}

		private void MainMenuSaveButton_Click(object sender, EventArgs e)
		{
			SaveProfile();
		}

		private void MainMenuAboutButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Borderlands 2 - Profile Editor 2.0\r\nby withmorten\r\n\r\nThanks to:\r\nPhilymaster (for the original Borderlands 2 - Profile Editor)\r\nFeudalnate (for PackageIO)\r\ngibbed (for MiniLZO and his Borderlands 2 Save Editor)\r\n\r\nHover over \"Synced Mode\", the number next to it and \"Ignore\"\r\nfor additional info", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void MainMenuCloseButton_Click(object sender, EventArgs e)
		{
			if (Program.Profile != null && ProfileDirty == true)
			{
				switch (MessageBox.Show("A profile is loaded, do you want to save it?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
				{
				case DialogResult.Yes:
					Program.Profile.Save(ProfileFilePath);

					Program.Profile = null;

					Application.Exit();

					break;

				case DialogResult.No:
					Program.Profile = null;

					Application.Exit();

					break;

				case DialogResult.Cancel:

					break;
				}
			}
			else
			{
				Application.Exit();
			}
		}

		private void UnlockAllCustomizationsButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will unlock all customizations (heads, skins),\r\noverwriting previous data, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				Program.Profile.UnlockAllCustomizations();

				ProfileDirty = true;

				MessageBox.Show("All customizations unlocked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				break;

			case DialogResult.No:

				break;
			}
		}

		private void LockAllCustomizationsButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will lock all customizations (heads, skins),\r\noverwriting previous data, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				Program.Profile.LockAllCustomizations();

				ProfileDirty = true;

				MessageBox.Show("All customizations locked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				break;

			case DialogResult.No:

				break;
			}
		}

		private void ResetBonusStatsButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will reset all bonus stats, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				TransferIgnoresToProfile();
				TransferToProfile();

				Program.Profile.ResetBonusStats();

				TransferFromProfile();

				ProfileDirty = true;

				break;

			case DialogResult.No:

				break;
			}
		}

		private void EvenlyDistributeTokensButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will spend all available tokens, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				TransferIgnoresToProfile();
				TransferToProfile();

				Program.Profile.EvenlyDistributeTokens();

				TransferFromProfile();

				ProfileDirty = true;

				break;

			case DialogResult.No:

				break;
			}
		}

		private void SyncedModeCheckBox_MouseHover(object sender, MouseEventArgs e)
		{
			if (SyncedModeToolTip.GetToolTip(SyncedModeCheckBox).Length == 0)
			{
				SyncedModeToolTip.SetToolTip(SyncedModeCheckBox,
					"Checking this will increase the Badass Rank automatically\r\nwhen you run out of available tokens");
			}
		}

		private void IgnoreBonusStatLabel_MouseHover(object sender, EventArgs e)
		{
			if (IgnoreBonusStatLabelToolTip.GetToolTip(IgnoreBonusStatLabel).Length == 0)
			{
				IgnoreBonusStatLabelToolTip.SetToolTip(IgnoreBonusStatLabel,
					"Checking the checkboxes below will make \r\n\"Reset Bonus Stats\" and \"Evenly Distribute Tokens\"\r\nignore the corresponding bonus stat");
			}
		}

		private void BadassTokensInvestedLabel_MouseHover(object sender, EventArgs e)
		{
			if (BadassTokensUsedToolTip.GetToolTip(BadassTokensInvestedLabel).Length == 0)
			{
				BadassTokensUsedToolTip.SetToolTip(BadassTokensInvestedLabel,
					"This shows the total number of Badass Tokens currently invested");
			}
		}

		private void CopySlot1CodeButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Program.Profile.GetClaptrapsStashSlotGibbedCode(1));

			MessageBox.Show("Slot 1 gibbed code copied to clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CopySlot2CodeButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Program.Profile.GetClaptrapsStashSlotGibbedCode(2));

			MessageBox.Show("Slot 2 gibbed code copied to clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CopySlot3CodeButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Program.Profile.GetClaptrapsStashSlotGibbedCode(3));

			MessageBox.Show("Slot 3 gibbed code copied to clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void CopySlot4CodeButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Program.Profile.GetClaptrapsStashSlotGibbedCode(4));

			MessageBox.Show("Slot 4 gibbed code copied to clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void PasteSlot1CodeButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will overwrite the current item in slot 1 with the code in the clipboard, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				if (Program.Profile.SetClaptrapsStashSlotGibbedCode(1, Clipboard.GetText()) == true)
				{
					ProfileDirty = true;

					MessageBox.Show("Slot 1 gibbed code pasted from clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

					CopySlot1CodeButton.Enabled = true;
					DeleteSlot1Button.Enabled = true;
				}
				else
				{
					MessageBox.Show("Not a valid gibbed code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				break;

			case DialogResult.No:

				break;
			}
		}

		private void PasteSlot2CodeButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will overwrite the current item in slot 2 with the code in the clipboard, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				if (Program.Profile.SetClaptrapsStashSlotGibbedCode(2, Clipboard.GetText()) == true)
				{
					ProfileDirty = true;

					MessageBox.Show("Slot 2 gibbed code pasted from clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

					CopySlot2CodeButton.Enabled = true;
					DeleteSlot2Button.Enabled = true;
				}
				else
				{
					MessageBox.Show("Not a valid gibbed code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				break;

			case DialogResult.No:

				break;
			}
		}

		private void PasteSlot3CodeButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will overwrite the current item in slot 3 with the code in the clipboard, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				if (Program.Profile.SetClaptrapsStashSlotGibbedCode(3, Clipboard.GetText()) == true)
				{
					ProfileDirty = true;

					MessageBox.Show("Slot 3 gibbed code pasted from clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

					CopySlot3CodeButton.Enabled = true;
					DeleteSlot3Button.Enabled = true;
				}
				else
				{
					MessageBox.Show("Not a valid gibbed code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				break;

			case DialogResult.No:

				break;
			}
		}

		private void PasteSlot4CodeButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will overwrite the current item in slot 4 with the code in the clipboard, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				if (Program.Profile.SetClaptrapsStashSlotGibbedCode(4, Clipboard.GetText()) == true)
				{
					ProfileDirty = true;

					MessageBox.Show("Slot 4 gibbed code pasted from clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

					CopySlot4CodeButton.Enabled = true;
					DeleteSlot4Button.Enabled = true;
				}
				else
				{
					MessageBox.Show("Not a valid gibbed code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				break;

			case DialogResult.No:

				break;
			}
		}

		private void DeleteSlot1Button_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will delete the current item in slot 1, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				Program.Profile.DeleteClaptrapsStashSlot(1);

				ProfileDirty = true;

				MessageBox.Show("Slot 1 deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				CopySlot1CodeButton.Enabled = false;
				DeleteSlot1Button.Enabled = false;

				break;

			case DialogResult.No:

				break;
			}
		}

		private void DeleteSlot2Button_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will delete the current item in slot 2, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				Program.Profile.DeleteClaptrapsStashSlot(2);

				ProfileDirty = true;

				MessageBox.Show("Slot 2 deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				CopySlot2CodeButton.Enabled = false;
				DeleteSlot2Button.Enabled = false;

				break;

			case DialogResult.No:

				break;
			}
		}

		private void DeleteSlot3Button_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will delete the current item in slot 3, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				Program.Profile.DeleteClaptrapsStashSlot(3);

				ProfileDirty = true;

				MessageBox.Show("Slot 3 deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				CopySlot3CodeButton.Enabled = false;
				DeleteSlot3Button.Enabled = false;

				break;

			case DialogResult.No:

				break;
			}
		}

		private void DeleteSlot4Button_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will delete the current item in slot 4, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				Program.Profile.DeleteClaptrapsStashSlot(4);

				ProfileDirty = true;

				MessageBox.Show("Slot 4 deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				CopySlot4CodeButton.Enabled = false;
				DeleteSlot4Button.Enabled = false;

				break;

			case DialogResult.No:

				break;
			}
		}

		private void MaxGoldenKeysButton_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show("This will set all golden keys to max, do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
			case DialogResult.Yes:
				GoldenKeysPOPremierClubInput.Value = 255;
				GoldenKeysPOPremierClubUsedInput.Value = 0;

				GoldenKeysTulipInput.Value = 255;
				GoldenKeysTulipUsedInput.Value = 0;

				GoldenKeysShiftInput.Value = 255;
				GoldenKeysShiftUsedInput.Value = 0;

				GoldenKeysTotalInput.Value = 765;

				ProfileDirty = true;

				break;

			case DialogResult.No:

				break;
			}
		}

		private static string[] RandomQuotes;

		private void InitializeRandomQuotes()
		{
			Array.Resize(ref RandomQuotes, 100);

			RandomQuotes[0]  = "A golden mallet for the meat pounding!";
			RandomQuotes[1]  = "How can I snap your neck if you don't have one?!";
			RandomQuotes[2]  = "I LOOKED INTO THE HEART OF DARKNESS, AND I ATE IT ALL!!!";
			RandomQuotes[3]  = "Why did your blood stop singing its sweet song...";
			RandomQuotes[4]  = "NIPPLE SALADS! Nipple salads... NIPPLE SALADS!";
			RandomQuotes[5]  = "Uhh... the choices are pretzeling my inner lobes!";
			RandomQuotes[6]  = "Your liver is a hood ornament!";
			RandomQuotes[7]  = "What's the hold up? / Is someone in the bathroom? / Are you on the phone?";
			RandomQuotes[8]  = "Your eyes deceive you / An illusion fools you all / I move for the kill.";
			RandomQuotes[9]  = "How hilarious / You just set off my trap card / Your death approaches.";
			RandomQuotes[10] = "The true world revealed / Weaknesses now known to me / Time to go to work.";
			RandomQuotes[11] = "And I disappear / A ghost amidst the combat / Preparing to strike.";
			RandomQuotes[12] = "Assassinated / What a satisfying word / With five syllables.";
			RandomQuotes[13] = "This is the story / All about how my life got / Flipped, turned upside-down.";
			RandomQuotes[14] = "This is interesting technology. I wonder how it -- oh God, I sound atrocious.";
			RandomQuotes[15] = "But, we let her live. Because that's what heroes do. They show mercy.";
			RandomQuotes[16] = "Hey, Slab!";
			RandomQuotes[17] = "OH GOD IN HEAVEN, I CAN TASTE MY OWN MELTING FLESH!";
			RandomQuotes[18] = "That's the sound of progress, baby.";
			RandomQuotes[19] = "And THAT'S how Handsome Jack pays ransoms!";
			RandomQuotes[20] = "You think a door can stop me, Jack?! I was MADE to open doors! HAHAHAHA!";
			RandomQuotes[21] = "Gotta keep those Bullymongs at bay, or they’ll rip your eyes out!";
			RandomQuotes[22] = "So, if you could just do me a favour and off yourself, that’d be great.";
			RandomQuotes[23] = "Oh GOD! They’re coming outta the wall-sphincters!";
			RandomQuotes[24] = "Spectacular -- first Captain Flynt’s bandits attack, then Claptrap shows up!";
			RandomQuotes[25] = "When Claptrap speaks, I can feel my brain cells committing suicide, one by one.";
			RandomQuotes[26] = "Bah – I’m spouting exposition again, aren’t I? Apologies!";
			RandomQuotes[27] = "If you shot the gate now, that could cause SERIOUS damage to me.";
			RandomQuotes[28] = "IT WAS JUST A QUESTION, MISTER FLYNT!!";
			RandomQuotes[29] = "Salt... good god where's my salt?!";
			RandomQuotes[30] = "Standing on immobile platforms is one of my top three favorite pastimes!";
			RandomQuotes[31] = "Executing phase shift.";
			RandomQuotes[32] = "I'm just gonna take a nap -- wake me up when I'm not on Pandora anymore.";
			RandomQuotes[33] = "Where are you Skrappy? Skrappy-y-y-y!";
			RandomQuotes[34] = "Ho-ly crap, somebody actually PAID for that?";
			RandomQuotes[35] = "Come back now! I get a little lonely! Heh, a lil' lonely.";
			RandomQuotes[36] = "He ate one of my cars once. Yeahhhh. The whole car. Just... like, with a fork.";
			RandomQuotes[37] = "Try not to die!";
			RandomQuotes[38] = "I am legally obligated to tell you that I ain't a real doctor.";
			RandomQuotes[39] = "I love the way you Vault Hunters just up and trusted Angel.";
			RandomQuotes[40] = "I just shut off the moonbase's oxygen supply.";
			RandomQuotes[41] = "What? Hell no. It's a miracle I didn't phase us into a mountain.";
			RandomQuotes[42] = "I'm an even better shot when I'm drunk!";
			RandomQuotes[43] = "Nobody steals Mushy Snugglebites' badonkadonk and lives!";
			RandomQuotes[44] = "WHO THE HELL IS MUSHY SNUGGLEBITES?!";
			RandomQuotes[45] = "Lady's got a gut fulla' dynamite and a booty like POWWW!";
			RandomQuotes[46] = "Ha ha! Man, this is one of them moments. CATCH A RIIIIDE!!!";
			RandomQuotes[47] = "EXPLOSIONS?!";
			RandomQuotes[48] = "THAT SENTENCE HAD TOO MANY SYLLABLES! APOLOGIZE!";
			RandomQuotes[49] = "NOTHING IS MORE BADASS THAN TREATING A WOMAN WITH RESPECT!";
			RandomQuotes[50] = "KIDS THESE DAYS AND THEIR CRAZY LANGUAGE AM I RIGHT!?";
			RandomQuotes[51] = "FANTASY STUFF! YEAH!";
			RandomQuotes[52] = "Squishy. Squishy squishy squishy.";
			RandomQuotes[53] = "BURN ALL THE BABIES!!!!!";
			RandomQuotes[54] = "Always love a good tip.";
			RandomQuotes[55] = "Thanks for the tips, sugar. I think it's time your generosity was... rewarded.";
			RandomQuotes[56] = "Hah, Clappy's havin' a shindig? You know, I'd go, but... I ain't gonna.";
			RandomQuotes[57] = "Oh my god, shut up, Dave.";
			RandomQuotes[58] = "Now, let's try that with the shield on. ";
			RandomQuotes[59] = "You know my favorite thing about Dave? He's dead.";
			RandomQuotes[60] = "You don't have all the guns, dear.";
			RandomQuotes[61] = "We're all broken because of them.";
			RandomQuotes[62] = "TIME TO COMPENSATE!";
			RandomQuotes[63] = "SOMETHING CLEVER!";
			RandomQuotes[64] = "We gotta get moving. I'm starting to think about stuff!";
			RandomQuotes[65] = "Ha! Did you see his face?";
			RandomQuotes[66] = "Sorry, boys, I've got turret syndrome! Get it? 'Cause of the turret...? Sorry.";
			RandomQuotes[67] = "YOU get a bullet! And YOU get a bullet! EVERYBODY gets a bullet!";
			RandomQuotes[68] = "Please excuse Madame Von Bartlesby's disposition. She's Welsh.";
			RandomQuotes[69] = "HAHAHA! I bet your mommy and daddy screamed as they died!";
			RandomQuotes[70] = "They're called 'Bonerfarts' now! Just go kill some or something.";
			RandomQuotes[71] = "My publisher says I can't call them 'Bonerfarts.'";
			RandomQuotes[72] = "That is mathematically HILARIOUS!";
			RandomQuotes[73] = "SHOOT ME IN THE FACE! IN THE FAAAAAAAACE!";
			RandomQuotes[74] = "And... ah, damn, I forgot the last one. What the hell was that, again?";
			RandomQuotes[75] = "Oh, now I remember! EXPLOSIIIIIIVE!";
			RandomQuotes[76] = "BLAKE! WHERE'S THE BLOODY VIOLIN?!";
			RandomQuotes[77] = "What do you MEAN they ain't from Hyperion?";
			RandomQuotes[78] = "We're all sooooo proud that you managed to kill off our friends and brothers.";
			RandomQuotes[79] = "Don't feel bad about killin' 'em. I never do.";
			RandomQuotes[80] = "Aaaaand kiss each other.";
			RandomQuotes[81] = "That Slab just blew up my buzzard without even lookin' at the explosion!";
			RandomQuotes[82] = "And, uh, make sure you don't look at Moxxi's footage.";
			RandomQuotes[83] = "Now that you've got the laxative, it's time to find some explosives.";
			RandomQuotes[84] = "Did you know that littering in Opportunity is punishable by death?";
			RandomQuotes[85] = "Remember, we should all love our parents, but love me more.";
			RandomQuotes[86] = "Did that thresher just eat the beacon? Uh... you'll need to get that back.";
			RandomQuotes[87] = "This jackhole rushes me with a spoon. A fricking spoon!";
			RandomQuotes[88] = "The moral is: you're a total bitch.";
			RandomQuotes[89] = "I am the conductor of the poop train!";
			RandomQuotes[90] = "I say MECHRO, you say MANCER. MECHRO! ...You guys suck!";
			RandomQuotes[91] = "Super Robot Violence Fun Time!";
			RandomQuotes[92] = "To hell with the First Law!";
			RandomQuotes[93] = "Meedly-meedly-mowwww...I know, I'm so bad at this.";
			RandomQuotes[94] = "BITCHIN AIR GUITAR SOLO! MEEYOWEYOWYOWYOWEEYOW!";
			RandomQuotes[95] = "ALLEN WRITE SOME DIALOGUE HERE!";
			RandomQuotes[96] = "STAIRS?! NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO!";
			RandomQuotes[97] = "Uh-oh. Math. Hope we don't pop a blood vessel.";
			RandomQuotes[98] = "We can use that to kill the deserving, grab it...";
			RandomQuotes[99] = "Look at me when I scream at your soul!";
		}

		private string GetRandomQuote()
		{
			if (RandomQuotes == null) InitializeRandomQuotes();

			Random random = new Random();

			return RandomQuotes[random.Next(0, 99)];
		}
	}
}
