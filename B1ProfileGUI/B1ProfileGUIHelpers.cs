using System;
using System.Windows.Forms;
using B1Profile;

namespace B1ProfileGUI
{
	public class BadassRankUpDown : NumericUpDown
	{
		public decimal PrevValue;

		public void Inc()
		{
			decimal nextRank = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);

			base.Increment = nextRank - base.Value;

			base.UpButton();

			PrevValue = base.Value;
		}

		public override void UpButton()
		{
			Program.MainForm.BadassTokensEarnedInput.Inc();
			Program.MainForm.BadassTokensAvailableInput.Inc();

			decimal nextRank = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);

			base.Increment = nextRank - base.Value;

			base.UpButton();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		public void Dec()
		{
			decimal prevRank = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);

			base.Increment = base.Value - prevRank;

			if (prevRank == base.Value)
			{
				prevRank = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);

				base.Increment = base.Value - prevRank;
			}

			base.DownButton();

			PrevValue = base.Value;
		}

		public override void DownButton()
		{
			decimal prevRank = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);

			base.Increment = base.Value - prevRank;

			if (prevRank == base.Value)
			{
				Program.MainForm.BadassTokensEarnedInput.Dec();
				Program.MainForm.BadassTokensAvailableInput.Dec();

				prevRank = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);

				base.Increment = base.Value - prevRank;
			}

			base.DownButton();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		protected override void OnValueChanged(EventArgs e)
		{
			base.OnValueChanged(e);

			if (base.UserEdit == true)
			{
				if (base.Value != PrevValue)
				{
					switch (MessageBox.Show("Editing this value manually can result in a weird state and will NOT be synced with the earned Badass Tokens value.\r\n\r\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
					{
					case DialogResult.Yes:
						Program.MainForm.ProfileDirty = true;

						break;

					case DialogResult.No:
						base.Value = PrevValue;

						break;
					}
				}
			}

			PrevValue = base.Value;
		}
	}

	public class BadassTokensEarnedUpDown : NumericUpDown
	{
		public decimal PrevValue;

		public void Inc()
		{
			base.UpButton();

			PrevValue = base.Value;
		}

		public override void UpButton()
		{
			base.UpButton();

			Program.MainForm.BadassRankInput.Inc();
			Program.MainForm.BadassTokensAvailableInput.Inc();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		public void Dec()
		{
			base.DownButton();

			PrevValue = base.Value;
		}

		public override void DownButton()
		{
			base.DownButton();

			Program.MainForm.BadassRankInput.Dec();
			Program.MainForm.BadassTokensAvailableInput.Dec();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		protected override void OnValueChanged(EventArgs e)
		{
			base.OnValueChanged(e);

			if (base.UserEdit == true)
			{
				Program.MainForm.BadassRankInput.Value = Profile.GetBadassRankFromTokens((uint)base.Value);

				Program.MainForm.TransferToProfile();

				if (base.Value > PrevValue)
				{
					Program.MainForm.BadassTokensAvailableInput.Value += (base.Value - PrevValue);
				}

				Program.MainForm.ProfileDirty = true;
			}

			PrevValue = base.Value;
		}
	}

	public class BadassTokensAvailableUpDown : NumericUpDown
	{
		public decimal PrevValue;

		public void Inc()
		{
			base.UpButton();

			PrevValue = base.Value;
		}

		public override void UpButton()
		{
			base.UpButton();

			Program.MainForm.TransferToProfile();

			if ((base.Value + Program.Profile.GetBadassTokensInvested()) > Program.MainForm.BadassTokensEarnedInput.Value)
			{
				if (Program.MainForm.SyncedModeCheckBox.Checked == true)
				{
					Program.MainForm.BadassTokensEarnedInput.Inc();
					Program.MainForm.BadassRankInput.Inc();
				}
			}

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		public void Dec()
		{
			base.DownButton();

			PrevValue = base.Value;
		}

		public override void DownButton()
		{
			base.DownButton();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		protected override void OnValueChanged(EventArgs e)
		{
			base.OnValueChanged(e);

			if (base.UserEdit == true)
			{
				if (base.Value > PrevValue)
				{
					if (Program.MainForm.SyncedModeCheckBox.Checked == true)
					{
						Program.MainForm.BadassTokensEarnedInput.Value += (base.Value - PrevValue);

						Program.MainForm.BadassRankInput.Value = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);
					}
				}

				Program.MainForm.ProfileDirty = true;
			}

			PrevValue = base.Value;
		}
	}

	public class BonusStatPercentUpDown : NumericUpDown
	{
		public BonusStatTokenUpDown TokenUpDown;

		public void Inc()
		{
			decimal nextPercent = (decimal)Math.Round(Math.Pow((double)TokenUpDown.Value, 0.75), 1);

			base.Increment = nextPercent - base.Value;

			base.UpButton();
		}

		public override void UpButton()
		{
			if (Program.MainForm.BadassTokensAvailableInput.Value > 0)
			{
				Program.MainForm.BadassTokensAvailableInput.Dec();
			}
			else
			{
				Program.MainForm.BadassTokensEarnedInput.Inc();
				Program.MainForm.BadassRankInput.Inc();
			}

			TokenUpDown.Inc();

			decimal nextPercent = (decimal)Math.Round(Math.Pow((double)TokenUpDown.Value, 0.75), 1);

			base.Increment = nextPercent - base.Value;

			base.UpButton();

			Program.MainForm.ProfileDirty = true;
		}

		public void Dec()
		{
			decimal prevPercent = (decimal)Math.Round(Math.Pow((double)TokenUpDown.Value, 0.75), 1);

			base.Increment = base.Value - prevPercent;

			base.DownButton();
		}

		public override void DownButton()
		{
			if (base.Value > 0)
			{
				Program.MainForm.BadassTokensAvailableInput.Inc();
			}

			TokenUpDown.Dec();

			decimal prevPercent = (decimal)Math.Round(Math.Pow((double)TokenUpDown.Value, 0.75), 1);

			base.Increment = base.Value - prevPercent;

			base.DownButton();

			Program.MainForm.ProfileDirty = true;
		}
	}

	public class BonusStatTokenUpDown : NumericUpDown
	{
		public BonusStatPercentUpDown PercentUpDown;

		public decimal PrevValue;

		public void Inc()
		{
			if (base.Value < base.Maximum) Program.MainForm.UpdateBadassTokensInvested(1);

			base.UpButton();

			PrevValue = base.Value;
		}

		public override void UpButton()
		{
			if (Program.MainForm.BadassTokensAvailableInput.Value > 0)
			{
				Program.MainForm.BadassTokensAvailableInput.Dec();
			}
			else
			{
				if (Program.MainForm.SyncedModeCheckBox.Checked == true)
				{
					Program.MainForm.BadassTokensEarnedInput.Inc();
					Program.MainForm.BadassRankInput.Inc();
				}
			}

			if (base.Value < base.Maximum) Program.MainForm.UpdateBadassTokensInvested(1);

			base.UpButton();

			PercentUpDown.Inc();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		public void Dec()
		{
			if (base.Value > base.Minimum) Program.MainForm.UpdateBadassTokensInvested(-1);

			base.DownButton();

			PrevValue = base.Value;
		}

		public override void DownButton()
		{
			if (base.Value > 0 && Program.MainForm.BadassTokensAvailableInput.Value < Program.MainForm.BadassTokensEarnedInput.Value)
			{
				Program.MainForm.BadassTokensAvailableInput.Inc();
			}

			if (base.Value > base.Minimum) Program.MainForm.UpdateBadassTokensInvested(-1);

			base.DownButton();

			PercentUpDown.Dec();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		protected override void OnValueChanged(EventArgs e)
		{
			base.OnValueChanged(e);

			if (base.UserEdit == true)
			{
				PercentUpDown.Value = (decimal)Profile.GetBonusPercentFromTokens((uint)base.Value);

				Program.MainForm.UpdateBadassTokensInvested(base.Value - PrevValue);

				if (PrevValue > base.Value)
				{
					Program.MainForm.BadassTokensAvailableInput.Value += (PrevValue - base.Value);
				}
				else if (PrevValue < base.Value)
				{
					if (Program.MainForm.BadassTokensAvailableInput.Value > 0)
					{
						if (Program.MainForm.BadassTokensAvailableInput.Value - (base.Value - PrevValue) < 0)
						{
							if (Program.MainForm.SyncedModeCheckBox.Checked == true)
							{
								Program.MainForm.BadassTokensEarnedInput.Value += (base.Value - PrevValue) - Program.MainForm.BadassTokensAvailableInput.Value;
								Program.MainForm.BadassRankInput.Value = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);
							}

							Program.MainForm.BadassTokensAvailableInput.Value = 0;
						}
						else
						{
							Program.MainForm.BadassTokensAvailableInput.Value -= (base.Value - PrevValue);
						}
					}
					else
					{
						if (Program.MainForm.SyncedModeCheckBox.Checked == true)
						{
							Program.MainForm.BadassTokensEarnedInput.Value += (base.Value - PrevValue);
							Program.MainForm.BadassRankInput.Value = Profile.GetBadassRankFromTokens((uint)Program.MainForm.BadassTokensEarnedInput.Value);
						}
					}
				}

				Program.MainForm.ProfileDirty = true;
			}

			PrevValue = base.Value;
		}
	}

	public class GoldenKeysUpDown : NumericUpDown
	{
		public GoldenKeysUsedUpDown KeysUsedUpDown;

		public decimal PrevValue;

		public void Inc()
		{
			base.UpButton();

			PrevValue = base.Value;
		}

		public override void UpButton()
		{
			if (base.Value < base.Maximum) Program.MainForm.GoldenKeysTotalInput.Inc();

			base.UpButton();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		public void Dec()
		{
			base.DownButton();

			PrevValue = base.Value;
		}

		public override void DownButton()
		{
			if (base.Value > base.Minimum) Program.MainForm.GoldenKeysTotalInput.Dec();

			if (base.Value == KeysUsedUpDown.Value) KeysUsedUpDown.Dec();

			base.DownButton();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		protected override void OnValueChanged(EventArgs e)
		{
			base.OnValueChanged(e);

			if (base.UserEdit == true)
			{
				if (base.Value < KeysUsedUpDown.Value)
				{
					Program.MainForm.GoldenKeysTotalInput.Value += (KeysUsedUpDown.Value - PrevValue);

					KeysUsedUpDown.Value = base.Value;
				}
				else
				{
					Program.MainForm.GoldenKeysTotalInput.Value += (PrevValue - base.Value);
				}

				Program.MainForm.ProfileDirty = true;
			}

			PrevValue = base.Value;
		}
	}

	public class GoldenKeysUsedUpDown : NumericUpDown
	{
		public GoldenKeysUpDown KeysUpDown;

		public decimal PrevValue;

		public void Inc()
		{
			base.UpButton();

			PrevValue = base.Value;
		}

		public override void UpButton()
		{
			if (base.Value < base.Maximum) Program.MainForm.GoldenKeysTotalInput.Dec();

			if (base.Value == KeysUpDown.Value) KeysUpDown.Inc();

			base.UpButton();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		public void Dec()
		{
			base.DownButton();

			PrevValue = base.Value;
		}

		public override void DownButton()
		{
			if (base.Value > base.Minimum) Program.MainForm.GoldenKeysTotalInput.Inc();

			base.DownButton();

			PrevValue = base.Value;

			Program.MainForm.ProfileDirty = true;
		}

		protected override void OnValueChanged(EventArgs e)
		{
			base.OnValueChanged(e);

			if (base.UserEdit == true)
			{
				if (base.Value > KeysUpDown.Value)
				{
					Program.MainForm.GoldenKeysTotalInput.Value += (PrevValue - KeysUpDown.Value);

					KeysUpDown.Value = base.Value;
				}
				else
				{
					Program.MainForm.GoldenKeysTotalInput.Value += (PrevValue - base.Value);
				}

				Program.MainForm.ProfileDirty = true;
			}

			PrevValue = base.Value;
		}
	}

	public class GoldenKeysTotalUpDown : NumericUpDown
	{
		public void Inc()
		{
			base.UpButton();
		}

		public override void UpButton()
		{
			if (base.Value < base.Maximum)
			{
				base.UpButton();

				Program.MainForm.ProfileDirty = true;

				if (Program.MainForm.GoldenKeysPOPremierClubInput.Value < 255)
				{
					Program.MainForm.GoldenKeysPOPremierClubInput.Inc();

					return;
				}

				if (Program.MainForm.GoldenKeysPOPremierClubUsedInput.Value > 0)
				{
					Program.MainForm.GoldenKeysPOPremierClubUsedInput.Dec();

					return;
				}

				if (Program.MainForm.GoldenKeysTulipInput.Value < 255)
				{
					Program.MainForm.GoldenKeysTulipInput.Inc();

					return;
				}

				if (Program.MainForm.GoldenKeysTulipUsedInput.Value > 0)
				{
					Program.MainForm.GoldenKeysTulipUsedInput.Dec();

					return;
				}

				if (Program.MainForm.GoldenKeysShiftInput.Value < 255)
				{
					Program.MainForm.GoldenKeysShiftInput.Inc();

					return;
				}

				if (Program.MainForm.GoldenKeysShiftUsedInput.Value > 0)
				{
					Program.MainForm.GoldenKeysShiftUsedInput.Dec();

					return;
				}
			}
		}

		public void Dec()
		{
			base.DownButton();
		}

		public override void DownButton()
		{
			if (base.Value > base.Minimum)
			{
				base.DownButton();

				Program.MainForm.ProfileDirty = true;

				if (Program.MainForm.GoldenKeysPOPremierClubInput.Value > 0)
				{
					Program.MainForm.GoldenKeysPOPremierClubInput.Dec();

					return;
				}

				if (Program.MainForm.GoldenKeysPOPremierClubUsedInput.Value < 255)
				{
					Program.MainForm.GoldenKeysPOPremierClubUsedInput.Inc();

					return;
				}

				if (Program.MainForm.GoldenKeysTulipInput.Value > 0)
				{
					Program.MainForm.GoldenKeysTulipInput.Dec();

					return;
				}

				if (Program.MainForm.GoldenKeysTulipUsedInput.Value < 255)
				{
					Program.MainForm.GoldenKeysTulipUsedInput.Inc();

					return;
				}

				if (Program.MainForm.GoldenKeysShiftInput.Value > 0)
				{
					Program.MainForm.GoldenKeysShiftInput.Dec();

					return;
				}

				if (Program.MainForm.GoldenKeysShiftUsedInput.Value < 255)
				{
					Program.MainForm.GoldenKeysShiftUsedInput.Inc();

					return;
				}
			}
		}
	}
}
