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
    public partial class ChangeExtension : Form
    {
        public ChangeExtension()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Select the folder which contains your files.";
            dlg.ShowDialog();
            string path = dlg.SelectedPath;
            txtFolderPath.Text = path;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeFileExtension(txtFolderPath.Text);
            MessageBox.Show("Extension has been changed successfully");
        }

        private void ChangeFileExtension(string path)
        {
            string[] files = Directory.GetFiles(path);
            string targetExt = txtExtension.Text;
            foreach (var file in files)
            {
                string oldPath = file;
                string currentExt = Path.GetExtension(file);
                string newPath = path + "\\"+Path.GetFileNameWithoutExtension(file) + targetExt;
                try
                {
                    File.Move(oldPath, newPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
