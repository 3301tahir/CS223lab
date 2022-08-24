using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223lab
{
    public partial class FormSQLConn : Form
    {
        public FormSQLConn()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = @"Data Source = localhost; Initial Catalog = University2; Integrated Security = True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                // MessageBox.Show("Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                
        }
    }
}
