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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(tbUsername.Text))
                {
                    errorProvider1.SetError(tbUsername, "This field is required");
                    return;
                }
                if (String.IsNullOrEmpty(tbPassword.Text))
                {
                    errorProvider1.SetError(tbPassword, "This field is required");
                    return;
                }
                if (tbPassword.Text.Equals("admin"))
                {
                    this.Hide();
                    FormMain form = new FormMain(tbUsername.Text);
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Credentials");
                }
            }
                           
        }
    }
}
