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
    public partial class FormDisplay : Form
    {
        public FormDisplay()
        {
            InitializeComponent();
        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            foreach (Product item in Product.GetAllProducts())
            {
                UCProductCard card = new UCProductCard();
                card.ProductNumber = item.productNumber;
                card.InventoryNumber = item.inventoryNumber;
                card.Name = item.name;

                // Click event handler
                card.Click += (Object sender, EventArgs e) =>
                {
                    FormPCDetails form = new(item);
                    form.Show();
                };

                flowLayoutPanel1.Controls.Add(card);

            }
        }
    }
}
