using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223lab
{
    public partial class FormMain : Form
    {
        public FormMain(string loggedInUsername)
        {
            InitializeComponent();
        }

        private void addRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormManageProducts f = new();
            f.MdiParent = this;
            f.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormSearch f = new();
            f.MdiParent = this;
            f.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormDisplay f = new();
            f.MdiParent = this;
            f.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MySQLConnection.CheckConnection();
        }
    }
}
