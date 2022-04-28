using System;
using System.Windows.Forms;
using B1Profile;

namespace B1ProfileGUI
{
	public class NumGoldenKeysUpDown : NumericUpDown
	{
		public override void UpButton()
		{
			base.UpButton();

			Program.MainForm.ProfileDirty = true;
		}

		public override void DownButton()
		{
			base.DownButton();

			Program.MainForm.ProfileDirty = true;
		}

		protected override void OnValueChanged(EventArgs e)
		{
			base.OnValueChanged(e);

			Program.MainForm.ProfileDirty = true;
		}
	}
}
