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
    public partial class FormPCDetails : Form
    {
        public FormPCDetails(Product product)
        {
            InitializeComponent();
            label1.Text = product.productNumber;
            label2.Text = product.inventoryNumber;
            label3.Text = product.dateAdded.ToString();
            label4.Text = product.name;
            label5.Text = product.count.ToString();
            label6.Text = product.price.ToString();
            label7.Text = product.availability ? "Yes" : "No";
            label8.Text = product.delivery ? "Yes" : "No";
            label9.Text = product.installation ? "Yes" : "No";
        }
    }
}
