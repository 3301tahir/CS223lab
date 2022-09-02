using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CS223lab
{
    public class Product
    {
        public string productNumber { get; set; }
        public string inventoryNumber { get; set; }
        public DateTime dateAdded { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public bool availability { get; set; }
        public bool delivery { get; set; }
        public bool warranty { get; set; }

        // static private List<Product> list = new List<Product>();

        public void Add()
        {
            string query = "EXEC CreateProduct " +
                "@productNumber, " +
                "@inventoryNumber, " +
                "@dateAdded, " +
                "@name, " +
                "@count, " +
                "@price, " +
                "@availability, " +
                "@delivery, " +
                "@warranty ";

            try
            {
                using (SqlConnection conn = new SqlConnection(MySQLConnection.connString))
                {
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@productNumber", this.productNumber);
                    cmd.Parameters.AddWithValue("@inventoryNumber", this.inventoryNumber);
                    cmd.Parameters.AddWithValue("@dateAdded", this.dateAdded);
                    cmd.Parameters.AddWithValue("@name", this.name);
                    cmd.Parameters.AddWithValue("@count", this.count);
                    cmd.Parameters.AddWithValue("@price", this.price);
                    cmd.Parameters.AddWithValue("@availability", Convert.ToInt32(this.availability));
                    cmd.Parameters.AddWithValue("@delivery", Convert.ToInt32(this.delivery));
                    cmd.Parameters.AddWithValue("@warranty", Convert.ToInt32(this.warranty));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product " + this.productNumber + " added");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void Update(Product updatedProduct)
        {
            string query = "EXEC UpdateProduct " +
                "@productNumber, " +
                "@inventoryNumber, " +
                "@dateAdded, " +
                "@name, " +
                "@count, " +
                "@price, " +
                "@availability, " +
                "@delivery, " +
                "@warranty, " +
                "@oldProductNumber ";
            try
            {
                using (SqlConnection conn = new SqlConnection(MySQLConnection.connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@productNumber", updatedProduct.productNumber);
                    cmd.Parameters.AddWithValue("@inventoryNumber", updatedProduct.inventoryNumber);
                    cmd.Parameters.AddWithValue("@dateAdded", updatedProduct.dateAdded);
                    cmd.Parameters.AddWithValue("@name", updatedProduct.name);
                    cmd.Parameters.AddWithValue("@count", updatedProduct.count);
                    cmd.Parameters.AddWithValue("@price", updatedProduct.price);
                    cmd.Parameters.AddWithValue("@availability", Convert.ToInt32(updatedProduct.availability));
                    cmd.Parameters.AddWithValue("@delivery", Convert.ToInt32(updatedProduct.delivery));
                    cmd.Parameters.AddWithValue("@warranty", Convert.ToInt32(updatedProduct.warranty));
                    cmd.Parameters.AddWithValue("@oldProductNumber", this.productNumber);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product " + this.productNumber + " updated");
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Remove()
        {
            string query = "EXEC DeleteProduct @productNumber";
            try
            {
                using (SqlConnection conn = new SqlConnection(MySQLConnection.connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@productNumber", this.productNumber);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product " + this.productNumber + " removed");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        static public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            string query = "EXEC GetAllProducts";

            try
            {
                using (SqlConnection conn = new SqlConnection(MySQLConnection.connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query,conn);

                    SqlDataReader resultSet = cmd.ExecuteReader();
                    while (resultSet.Read())
                    {
                        Product product = new Product
                        {
                            productNumber = resultSet["productNumber"].ToString(),
                            inventoryNumber = resultSet["inventoryNumber"].ToString(),
                            name = resultSet["name"].ToString(),

                            dateAdded = DateTime.Parse(resultSet["dateAdded"].ToString()),

                            count = Convert.ToInt32(resultSet["count"]),
                            price = Convert.ToDouble(resultSet["price"]),

                            availability = Convert.ToBoolean(resultSet["availability"]),
                            delivery = Convert.ToBoolean(resultSet["delivery"]),
                            warranty = Convert.ToBoolean(resultSet["warranty"])
                        };
                        list.Add(product);
                    }
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return list;
        }

        public static Product findByName(string name)
        {
            List<Product> list = GetAllProducts();
            return list.Find(list => list.name == name);
        }

    }
}
