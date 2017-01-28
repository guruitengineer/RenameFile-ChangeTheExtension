using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtility
{
    public partial class SelectTask : Form
    {
        public SelectTask()
        {
            InitializeComponent();
        }

        private void btnRenameFiles_Click(object sender, EventArgs e)
        {
            RenameFile sf = new RenameFile();
            sf.Show();
            this.Hide();
        }

        private void btnChangeExt_Click(object sender, EventArgs e)
        {
            ChangeExtension ce = new ChangeExtension();
            ce.Show();
            this.Hide();
        }
    }
}
