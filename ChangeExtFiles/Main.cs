using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ChangeExtFiles
{
	public partial class Main : MetroForm
	{
		private DirectoryInfo _selectedPath;
		public Main()
		{
			InitializeComponent();
		}

		private void btn_browse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
			{
				Tag = "Select Path"
			};
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				_selectedPath = new DirectoryInfo(folderBrowserDialog.SelectedPath);
				lbl_path.Text = _selectedPath.FullName;
			}

		}

		private void btn_Start_Click(object sender, EventArgs e)
		{
			string cutText = txt_cut.Text;
			int progress = 0;
			if (_selectedPath == null || cutText == "")
			{
				return;
			}

			btn_Start.Enabled = false;
			btn_browse.Enabled = false;
			txt_cut.Enabled = false;
			prg_bar.Value = progress;
			var files = _selectedPath.GetFiles("*", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				progress++;
				var newProgress =  progress * 100  / files.Length;
				prg_bar.Value = newProgress;
				if (file.FullName.Contains(cutText))
				{
					file.MoveTo(file.FullName.Substring(0,file.FullName.Length-cutText.Length));
				}
			}
			btn_Start.Enabled = true;
			btn_browse.Enabled = true;
			txt_cut.Enabled = true;
			prg_bar.Value = 0;
			_selectedPath = null;
			lbl_path.Text = "DONE SUCCESSFULLY";
		}
	}
}
