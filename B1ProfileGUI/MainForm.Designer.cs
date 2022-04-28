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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenuBar = new System.Windows.Forms.ToolStrip();
			this.MainMenuOpenButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuSaveButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuAboutButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuCloseButton = new System.Windows.Forms.ToolStripButton();
			this.NumGoldenKeysLabel = new System.Windows.Forms.Label();
			this.NumGoldenKeysInput = new B1ProfileGUI.NumGoldenKeysUpDown();
			this.MainMenuBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumGoldenKeysInput)).BeginInit();
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
			this.MainMenuBar.Size = new System.Drawing.Size(314, 25);
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
			// NumGoldenKeysLabel
			// 
			this.NumGoldenKeysLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.NumGoldenKeysLabel.AutoSize = true;
			this.NumGoldenKeysLabel.Location = new System.Drawing.Point(122, 34);
			this.NumGoldenKeysLabel.Name = "NumGoldenKeysLabel";
			this.NumGoldenKeysLabel.Size = new System.Drawing.Size(70, 13);
			this.NumGoldenKeysLabel.TabIndex = 1;
			this.NumGoldenKeysLabel.Text = "Golden Keys:";
			// 
			// NumGoldenKeysInput
			// 
			this.NumGoldenKeysInput.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.NumGoldenKeysInput.Enabled = false;
			this.NumGoldenKeysInput.Location = new System.Drawing.Point(138, 59);
			this.NumGoldenKeysInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.NumGoldenKeysInput.Name = "NumGoldenKeysInput";
			this.NumGoldenKeysInput.Size = new System.Drawing.Size(38, 20);
			this.NumGoldenKeysInput.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 100);
			this.Controls.Add(this.NumGoldenKeysLabel);
			this.Controls.Add(this.NumGoldenKeysInput);
			this.Controls.Add(this.MainMenuBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Borderlands Profile Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainMenuBar.ResumeLayout(false);
			this.MainMenuBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumGoldenKeysInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripButton MainMenuOpenButton;
		private System.Windows.Forms.ToolStripButton MainMenuSaveButton;
		private System.Windows.Forms.ToolStripButton MainMenuAboutButton;
		private System.Windows.Forms.ToolStripButton MainMenuCloseButton;
		private System.Windows.Forms.ToolStrip MainMenuBar;
		private System.Windows.Forms.Label NumGoldenKeysLabel;
		private B1ProfileGUI.NumGoldenKeysUpDown NumGoldenKeysInput;
	}
}
