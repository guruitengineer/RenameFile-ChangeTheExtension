using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileUtility
{
    public partial class RenameFile : Form
    {
        public RenameFile()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Select the folder which contains your files.";
            dlg.ShowDialog();
            string path=dlg.SelectedPath;
            txtFolderPath.Text = path;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            ReadFileNameAndRename(txtFolderPath.Text);
            MessageBox.Show("All files have been renamed");
        }

        private void ReadFileNameAndRename(string path)
        {
            string[] files=Directory.GetFiles(path);
            int counter=Convert.ToInt32(cntVal.Value);
            if (!Directory.Exists(path + "\\renamed\\"))
                Directory.CreateDirectory(path + "\\renamed\\");
            foreach (var file in files)
            {
                string oldPath = file;
                string ext= Path.GetExtension(oldPath);
                string newPath = path + "\\renamed\\" + Convert.ToString(counter) +ext;
                try
                {
                    File.Copy(oldPath, newPath);
                }
                catch (Exception)
                {
                    continue;
                }
                counter++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectTask st = new SelectTask();
            st.Show();
            this.Hide();
        }
    }
}
