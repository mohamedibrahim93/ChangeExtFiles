namespace ChangeExtFiles
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.btn_browse = new MetroFramework.Controls.MetroTile();
			this.btn_Start = new MetroFramework.Controls.MetroTile();
			this.lbl_path = new MetroFramework.Controls.MetroLabel();
			this.txt_cut = new MetroFramework.Controls.MetroTextBox();
			this.prg_bar = new MetroFramework.Controls.MetroProgressBar();
			this.SuspendLayout();
			// 
			// btn_browse
			// 
			this.btn_browse.ActiveControl = null;
			this.btn_browse.Location = new System.Drawing.Point(62, 161);
			this.btn_browse.Name = "btn_browse";
			this.btn_browse.Size = new System.Drawing.Size(158, 75);
			this.btn_browse.Style = MetroFramework.MetroColorStyle.Orange;
			this.btn_browse.TabIndex = 0;
			this.btn_browse.Text = "Select Path";
			this.btn_browse.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.btn_browse.UseSelectable = true;
			this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
			// 
			// btn_Start
			// 
			this.btn_Start.ActiveControl = null;
			this.btn_Start.Location = new System.Drawing.Point(256, 161);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(158, 75);
			this.btn_Start.Style = MetroFramework.MetroColorStyle.Green;
			this.btn_Start.TabIndex = 1;
			this.btn_Start.Text = "Start";
			this.btn_Start.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.btn_Start.UseSelectable = true;
			this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
			// 
			// lbl_path
			// 
			this.lbl_path.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lbl_path.Location = new System.Drawing.Point(62, 248);
			this.lbl_path.Name = "lbl_path";
			this.lbl_path.Size = new System.Drawing.Size(352, 30);
			this.lbl_path.Style = MetroFramework.MetroColorStyle.Black;
			this.lbl_path.TabIndex = 2;
			this.lbl_path.Text = "No Folder Selected ...";
			this.lbl_path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_cut
			// 
			// 
			// 
			// 
			this.txt_cut.CustomButton.Image = null;
			this.txt_cut.CustomButton.Location = new System.Drawing.Point(330, 1);
			this.txt_cut.CustomButton.Name = "";
			this.txt_cut.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txt_cut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txt_cut.CustomButton.TabIndex = 1;
			this.txt_cut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txt_cut.CustomButton.UseSelectable = true;
			this.txt_cut.CustomButton.Visible = false;
			this.txt_cut.Lines = new string[0];
			this.txt_cut.Location = new System.Drawing.Point(62, 79);
			this.txt_cut.MaxLength = 32767;
			this.txt_cut.Name = "txt_cut";
			this.txt_cut.PasswordChar = '\0';
			this.txt_cut.PromptText = ".txt";
			this.txt_cut.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txt_cut.SelectedText = "";
			this.txt_cut.SelectionLength = 0;
			this.txt_cut.SelectionStart = 0;
			this.txt_cut.ShortcutsEnabled = true;
			this.txt_cut.Size = new System.Drawing.Size(352, 23);
			this.txt_cut.Style = MetroFramework.MetroColorStyle.Brown;
			this.txt_cut.TabIndex = 3;
			this.txt_cut.UseSelectable = true;
			this.txt_cut.WaterMark = ".txt";
			this.txt_cut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txt_cut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// prg_bar
			// 
			this.prg_bar.Location = new System.Drawing.Point(62, 119);
			this.prg_bar.Name = "prg_bar";
			this.prg_bar.Size = new System.Drawing.Size(352, 23);
			this.prg_bar.TabIndex = 4;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 290);
			this.Controls.Add(this.prg_bar);
			this.Controls.Add(this.txt_cut);
			this.Controls.Add(this.lbl_path);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.btn_browse);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Resizable = false;
			this.Text = "AL-Driny";
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTile btn_browse;
		private MetroFramework.Controls.MetroTile btn_Start;
		private MetroFramework.Controls.MetroLabel lbl_path;
		private MetroFramework.Controls.MetroTextBox txt_cut;
		private MetroFramework.Controls.MetroProgressBar prg_bar;
	}
}

