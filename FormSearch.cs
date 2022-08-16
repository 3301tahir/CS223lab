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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Product searchResult = Product.findByName(tbSearch.Text);
            if (searchResult == null)
                MessageBox.Show("No matching product!");
            else
                MessageBox.Show("Product number: " + searchResult.productNumber);
        }
    }
}
