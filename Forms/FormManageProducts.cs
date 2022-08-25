using System.Text.RegularExpressions;

namespace CS223lab
{
    public partial class FormManageProducts : Form
    {
        public FormManageProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductsList.DataSource = Product.GetAllProducts();
            dgvProductsList.ClearSelection();
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
                        warranty = checkAdditionalWarranty.Checked
                    };
                    newProduct.Add();
                    MessageBox.Show("Product added");

                    // Refresh DGV
                    dgvProductsList.DataSource = null;
                    dgvProductsList.DataSource = Product.GetAllProducts();
                    dgvProductsList.ClearSelection();

                    // Clear fields
                    btnClear_Click(sender, e);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductsList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select product to remove!");
                    return;
                }
                Product selectedProduct = dgvProductsList.SelectedRows[0].DataBoundItem as Product;
                Product updatedProduct = new Product
                {
                        productNumber = tbProductNo.Text,
                        inventoryNumber = tbInventoryNo.Text,
                        dateAdded = dateTimePicker1.Value,
                        name = tbProductName.Text,
                        count = int.Parse(tbCount.Text),
                        price = double.Parse(tbPrice.Text),
                        availability = radioAvailabilityYes.Checked,
                        delivery = checkAdditionalDelivery.Checked,
                        warranty = checkAdditionalWarranty.Checked
                };
                selectedProduct.Update(updatedProduct);
                MessageBox.Show("Product updated");

                // Refresh DGV
                dgvProductsList.DataSource = null;
                dgvProductsList.DataSource = Product.GetAllProducts();
                dgvProductsList.ClearSelection();

                // Clear fields
                btnClear_Click(sender, e);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductsList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select product to remove!");
                    return;
                }
                    
                (dgvProductsList.SelectedRows[0].DataBoundItem as Product).Remove();
                MessageBox.Show("Product removed");

                // Refresh DGV
                dgvProductsList.DataSource = null;
                dgvProductsList.DataSource = Product.GetAllProducts();
                dgvProductsList.ClearSelection();

                // Clear fields
                btnClear_Click(sender, e);

            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
            checkAdditionalWarranty.Checked = false;

            dateTimePicker1.Value = DateTime.Now;

        }

        private void dgvProductsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductsList.SelectedRows.Count == 0)
                return;
            Product selectedProduct = dgvProductsList.SelectedRows[0].DataBoundItem as Product;
            tbProductNo.Text = selectedProduct.productNumber;
            tbInventoryNo.Text = selectedProduct.inventoryNumber;
            tbProductName.Text = selectedProduct.name;

            tbCount.Text = selectedProduct.count.ToString();
            tbPrice.Text = selectedProduct.price.ToString();

            if (selectedProduct.availability)
                radioAvailabilityYes.Checked = true;
            else
                radioAvailabilityNo.Checked = true;

            checkAdditionalDelivery.Checked = selectedProduct.delivery;
            checkAdditionalWarranty.Checked = selectedProduct.warranty;

            dateTimePicker1.Value = selectedProduct.dateAdded;
        }
    }
}