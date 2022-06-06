namespace B1ProfileGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainMenuBar = new System.Windows.Forms.ToolStrip();
			this.MainMenuOpenButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuSaveButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuAboutButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuCloseButton = new System.Windows.Forms.ToolStripButton();
			this.GoldenKeysLabel = new System.Windows.Forms.Label();
			this.GoldenKeysUsedLabel = new System.Windows.Forms.Label();
			this.GoldenKeysTotalLabel = new System.Windows.Forms.Label();
			this.MaxGoldenKeysButton = new System.Windows.Forms.Button();
			this.GoldenKeysTotalInput = new B1ProfileGUI.GoldenKeysTotalUpDown();
			this.GoldenKeysUsedInput = new B1ProfileGUI.GoldenKeysUsedUpDown();
			this.GoldenKeysInput = new B1ProfileGUI.GoldenKeysUpDown();
			this.MainMenuBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GoldenKeysTotalInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GoldenKeysUsedInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GoldenKeysInput)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenuBar
			// 
			this.MainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuOpenButton,
            this.MainMenuSaveButton,
            this.MainMenuAboutButton,
            this.MainMenuCloseButton});
			this.MainMenuBar.Location = new System.Drawing.Point(0, 0);
			this.MainMenuBar.Name = "MainMenuBar";
			this.MainMenuBar.Size = new System.Drawing.Size(357, 25);
			this.MainMenuBar.TabIndex = 0;
			this.MainMenuBar.Text = "Main Menu";
			// 
			// MainMenuOpenButton
			// 
			this.MainMenuOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MainMenuOpenButton.Image = global::B1ProfileGUI.Properties.Resources.MainMenu_Open;
			this.MainMenuOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MainMenuOpenButton.Name = "MainMenuOpenButton";
			this.MainMenuOpenButton.Size = new System.Drawing.Size(23, 22);
			this.MainMenuOpenButton.Text = "Open";
			this.MainMenuOpenButton.Click += new System.EventHandler(this.MainMenuOpenButton_Click);
			// 
			// MainMenuSaveButton
			// 
			this.MainMenuSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MainMenuSaveButton.Enabled = false;
			this.MainMenuSaveButton.Image = global::B1ProfileGUI.Properties.Resources.MainMenu_Save;
			this.MainMenuSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MainMenuSaveButton.Name = "MainMenuSaveButton";
			this.MainMenuSaveButton.Size = new System.Drawing.Size(23, 22);
			this.MainMenuSaveButton.Text = "Save";
			this.MainMenuSaveButton.Click += new System.EventHandler(this.MainMenuSaveButton_Click);
			// 
			// MainMenuAboutButton
			// 
			this.MainMenuAboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MainMenuAboutButton.Image = global::B1ProfileGUI.Properties.Resources.MainMenu_About;
			this.MainMenuAboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MainMenuAboutButton.Name = "MainMenuAboutButton";
			this.MainMenuAboutButton.Size = new System.Drawing.Size(23, 22);
			this.MainMenuAboutButton.Text = "About";
			this.MainMenuAboutButton.Click += new System.EventHandler(this.MainMenuAboutButton_Click);
			// 
			// MainMenuCloseButton
			// 
			this.MainMenuCloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MainMenuCloseButton.Image = global::B1ProfileGUI.Properties.Resources.MainMenu_Close;
			this.MainMenuCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MainMenuCloseButton.Name = "MainMenuCloseButton";
			this.MainMenuCloseButton.Size = new System.Drawing.Size(23, 22);
			this.MainMenuCloseButton.Text = "Close";
			this.MainMenuCloseButton.Click += new System.EventHandler(this.MainMenuCloseButton_Click);
			// 
			// GoldenKeysLabel
			// 
			this.GoldenKeysLabel.AutoSize = true;
			this.GoldenKeysLabel.Location = new System.Drawing.Point(12, 38);
			this.GoldenKeysLabel.Name = "GoldenKeysLabel";
			this.GoldenKeysLabel.Size = new System.Drawing.Size(70, 13);
			this.GoldenKeysLabel.TabIndex = 0;
			this.GoldenKeysLabel.Text = "Golden Keys:";
			// 
			// GoldenKeysUsedLabel
			// 
			this.GoldenKeysUsedLabel.AutoSize = true;
			this.GoldenKeysUsedLabel.Location = new System.Drawing.Point(12, 65);
			this.GoldenKeysUsedLabel.Name = "GoldenKeysUsedLabel";
			this.GoldenKeysUsedLabel.Size = new System.Drawing.Size(98, 13);
			this.GoldenKeysUsedLabel.TabIndex = 0;
			this.GoldenKeysUsedLabel.Text = "Golden Keys Used:";
			// 
			// GoldenKeysTotalLabel
			// 
			this.GoldenKeysTotalLabel.AutoSize = true;
			this.GoldenKeysTotalLabel.Location = new System.Drawing.Point(12, 100);
			this.GoldenKeysTotalLabel.Name = "GoldenKeysTotalLabel";
			this.GoldenKeysTotalLabel.Size = new System.Drawing.Size(97, 13);
			this.GoldenKeysTotalLabel.TabIndex = 0;
			this.GoldenKeysTotalLabel.Text = "Golden Keys Total:";
			// 
			// MaxGoldenKeysButton
			// 
			this.MaxGoldenKeysButton.Enabled = false;
			this.MaxGoldenKeysButton.Location = new System.Drawing.Point(240, 97);
			this.MaxGoldenKeysButton.Name = "MaxGoldenKeysButton";
			this.MaxGoldenKeysButton.Size = new System.Drawing.Size(100, 23);
			this.MaxGoldenKeysButton.TabIndex = 4;
			this.MaxGoldenKeysButton.Text = "Max Golden Keys";
			this.MaxGoldenKeysButton.UseVisualStyleBackColor = true;
			this.MaxGoldenKeysButton.Click += new System.EventHandler(this.MaxGoldenKeysButton_Click);
			// 
			// GoldenKeysTotalInput
			// 
			this.GoldenKeysTotalInput.BackColor = System.Drawing.SystemColors.Control;
			this.GoldenKeysTotalInput.Enabled = false;
			this.GoldenKeysTotalInput.Location = new System.Drawing.Point(132, 98);
			this.GoldenKeysTotalInput.Name = "GoldenKeysTotalInput";
			this.GoldenKeysTotalInput.Size = new System.Drawing.Size(81, 20);
			this.GoldenKeysTotalInput.TabIndex = 3;
			this.GoldenKeysTotalInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// GoldenKeysUsedInput
			// 
			this.GoldenKeysUsedInput.Enabled = false;
			this.GoldenKeysUsedInput.Location = new System.Drawing.Point(132, 63);
			this.GoldenKeysUsedInput.Name = "GoldenKeysUsedInput";
			this.GoldenKeysUsedInput.Size = new System.Drawing.Size(81, 20);
			this.GoldenKeysUsedInput.TabIndex = 2;
			this.GoldenKeysUsedInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// GoldenKeysInput
			// 
			this.GoldenKeysInput.Enabled = false;
			this.GoldenKeysInput.Location = new System.Drawing.Point(132, 36);
			this.GoldenKeysInput.Name = "GoldenKeysInput";
			this.GoldenKeysInput.Size = new System.Drawing.Size(81, 20);
			this.GoldenKeysInput.TabIndex = 1;
			this.GoldenKeysInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 136);
			this.Controls.Add(this.MaxGoldenKeysButton);
			this.Controls.Add(this.GoldenKeysTotalInput);
			this.Controls.Add(this.GoldenKeysTotalLabel);
			this.Controls.Add(this.GoldenKeysUsedInput);
			this.Controls.Add(this.GoldenKeysUsedLabel);
			this.Controls.Add(this.GoldenKeysLabel);
			this.Controls.Add(this.GoldenKeysInput);
			this.Controls.Add(this.MainMenuBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainMenuBar.ResumeLayout(false);
			this.MainMenuBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GoldenKeysTotalInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GoldenKeysUsedInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GoldenKeysInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripButton MainMenuOpenButton;
		private System.Windows.Forms.ToolStripButton MainMenuSaveButton;
		private System.Windows.Forms.ToolStripButton MainMenuAboutButton;
		private System.Windows.Forms.ToolStripButton MainMenuCloseButton;
		private System.Windows.Forms.ToolStrip MainMenuBar;
		private System.Windows.Forms.Label GoldenKeysLabel;
		public B1ProfileGUI.GoldenKeysUpDown GoldenKeysInput;
		private System.Windows.Forms.Label GoldenKeysUsedLabel;
		public B1ProfileGUI.GoldenKeysUsedUpDown GoldenKeysUsedInput;
		private System.Windows.Forms.Label GoldenKeysTotalLabel;
		public B1ProfileGUI.GoldenKeysTotalUpDown GoldenKeysTotalInput;
		private System.Windows.Forms.Button MaxGoldenKeysButton;
	}
}
