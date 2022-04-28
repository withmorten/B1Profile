using System;
using System.Windows.Forms;
using B1Profile;

namespace B1ProfileGUI
{
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
					Program.MainForm.GoldenKeysTotalInput.Value += (base.Value - PrevValue);
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

				if (Program.MainForm.GoldenKeysInput.Value < Profile.MaxGoldenKeys)
				{
					Program.MainForm.GoldenKeysInput.Inc();

					return;
				}

				if (Program.MainForm.GoldenKeysUsedInput.Value > 0)
				{
					Program.MainForm.GoldenKeysUsedInput.Dec();

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

				if (Program.MainForm.GoldenKeysInput.Value > 0)
				{
					Program.MainForm.GoldenKeysInput.Dec();

					return;
				}

				if (Program.MainForm.GoldenKeysUsedInput.Value < Profile.MaxGoldenKeys)
				{
					Program.MainForm.GoldenKeysUsedInput.Inc();

					return;
				}
			}
		}
	}
}
