using System.Text.RegularExpressions;

namespace CS223lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductsList.DataSource = Product.GetAllProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (String.IsNullOrEmpty(tbProductNo.Text))
                errorProvider1.SetError(tbProductNo, "This field is required");
            else if (String.IsNullOrEmpty(tbInventoryNo.Text))
                errorProvider1.SetError(tbInventoryNo, "This field is required");
            else if (String.IsNullOrEmpty(tbProductName.Text))
                errorProvider1.SetError(tbProductName, "This field is required");
            else if (String.IsNullOrEmpty(tbCount.Text))
                errorProvider1.SetError(tbCount, "This field is required");
            else if (String.IsNullOrEmpty(tbPrice.Text))
                errorProvider1.SetError(tbPrice, "This field is required");
            
            // Check format using regex
            // NOT DONE

            else
            {
                try
                {
                    Product newProduct = new Product
                    {
                        productNumber = tbProductNo.Text,
                        inventoryNumber = tbInventoryNo.Text,
                        dateAdded = dateTimePicker1.Value,
                        name = tbProductName.Text,
                        count = int.Parse(tbCount.Text),
                        price = double.Parse(tbPrice.Text),
                        availability = radioAvailabilityYes.Checked,
                        delivery = checkAdditionalDelivery.Checked,
                        installation = checkAdditionalInstallation.Checked
                    };
                    Product.Add(newProduct);
                    MessageBox.Show("Product added");
                    // Refresh DGV
                    dgvProductsList.DataSource = null;
                    dgvProductsList.DataSource = Product.GetAllProducts();
                } 
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            /*
            if (dgvProductsList.SelectedRows.Count == 0)
                MessageBox.Show("Select product to remove!");
            else
            {
                Product.Remove(dgvProductsList.SelectedRows[0].DataBoundItem as Product);
                MessageBox.Show("Product removed");
            }
            */
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbProductNo.Clear();
            tbInventoryNo.Clear();
            tbProductName.Clear();
            tbCount.Clear();
            tbPrice.Clear();

            radioAvailabilityNo.Checked = false;
            radioAvailabilityYes.Checked = false;

            checkAdditionalDelivery.Checked = false;
            checkAdditionalInstallation.Checked = false;
        }
    }
}