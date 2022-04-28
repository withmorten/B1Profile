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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenuBar = new System.Windows.Forms.ToolStrip();
			this.MainMenuOpenButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuSaveButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuAboutButton = new System.Windows.Forms.ToolStripButton();
			this.MainMenuCloseButton = new System.Windows.Forms.ToolStripButton();
			this.SyncedModeToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.IgnoreBonusStatLabelToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.BadassTokensUsedToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.RandomQuoteLabel = new System.Windows.Forms.Label();
			this.MainMenuBar.SuspendLayout();
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
			this.MainMenuBar.Size = new System.Drawing.Size(758, 25);
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
			// SyncedModeToolTip
			// 
			this.SyncedModeToolTip.AutoPopDelay = 10000;
			this.SyncedModeToolTip.InitialDelay = 100;
			this.SyncedModeToolTip.ReshowDelay = 100;
			// 
			// IgnoreBonusStatLabelToolTip
			// 
			this.IgnoreBonusStatLabelToolTip.AutoPopDelay = 10000;
			this.IgnoreBonusStatLabelToolTip.InitialDelay = 100;
			this.IgnoreBonusStatLabelToolTip.ReshowDelay = 100;
			// 
			// BadassTokensUsedToolTip
			// 
			this.BadassTokensUsedToolTip.AutoPopDelay = 10000;
			this.BadassTokensUsedToolTip.InitialDelay = 100;
			this.BadassTokensUsedToolTip.ReshowDelay = 100;
			// 
			// RandomQuoteLabel
			// 
			this.RandomQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RandomQuoteLabel.Location = new System.Drawing.Point(12, 547);
			this.RandomQuoteLabel.Name = "RandomQuoteLabel";
			this.RandomQuoteLabel.Size = new System.Drawing.Size(437, 13);
			this.RandomQuoteLabel.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 580);
			this.Controls.Add(this.RandomQuoteLabel);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripButton MainMenuOpenButton;
		private System.Windows.Forms.ToolStripButton MainMenuSaveButton;
		private System.Windows.Forms.ToolStripButton MainMenuAboutButton;
		private System.Windows.Forms.ToolStripButton MainMenuCloseButton;
		private System.Windows.Forms.ToolStrip MainMenuBar;
		private System.Windows.Forms.ToolTip SyncedModeToolTip;
		private System.Windows.Forms.ToolTip IgnoreBonusStatLabelToolTip;
		private System.Windows.Forms.ToolTip BadassTokensUsedToolTip;
		private System.Windows.Forms.Label RandomQuoteLabel;
	}
}
