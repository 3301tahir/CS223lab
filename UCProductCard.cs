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
    public partial class UCProductCard : UserControl
    {
        private string _ProductNumber;
        public string ProductNumber
        {
            get { return _ProductNumber; }
            set { _ProductNumber = value; label1.Text = value; }
        }

        private string _InventoryNumber;
        public string InventoryNumber
        {
            get { return _InventoryNumber; }
            set { _InventoryNumber = value; label2.Text = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; label3.Text = value; }
        }

        public UCProductCard()
        {
            InitializeComponent();
        }
    }
}
