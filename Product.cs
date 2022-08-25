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
        public bool installation { get; set; }

        // static private List<Product> list = new List<Product>();

        public void Add()
        {
            string query = "INSERT INTO Product VALUES('" +
                this.productNumber + "', '" +
                this.inventoryNumber + "', '" +
                this.dateAdded + "', '" +
                this.name + "', " +
                this.count + ", " +
                this.price + ", " +
                Convert.ToInt32(this.availability) + ", " +
                Convert.ToInt32(this.delivery) + ", " +
                Convert.ToInt32(this.installation) + ")";
            try
            {
                MySQLConnection.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void Update(Product updatedProduct)
        {
            string query = "UPDATE Product SET " +
                "productNumber = '" + updatedProduct.productNumber + "', " +
                "inventoryNumber = '" + updatedProduct.inventoryNumber + "', " +
                "dateAdded = '" + updatedProduct.dateAdded + "', " +
                "name = '" + updatedProduct.name + "', " +
                "count = " + updatedProduct.count + ", " +
                "price = " + updatedProduct.price + ", " +
                "availability = " + Convert.ToInt32(updatedProduct.availability) + ", " +
                "delivery = " + Convert.ToInt32(updatedProduct.delivery) + ", " +
                "installation = " + Convert.ToInt32(updatedProduct.installation) + 
                " WHERE productNumber = '" + this.productNumber + "'";
            try
            {
                MySQLConnection.ExecuteNonQuery(query);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Remove()
        {
            string query = "DELETE FROM Product WHERE productNumber = '" +
                this.productNumber + "'";
            try
            {
                MySQLConnection.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        static public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            string query = "SELECT * FROM Product";

            try
            {
                SqlDataReader resultSet = MySQLConnection.ExecuteReader(query);
                while (resultSet.Read())
                {
                    Product product = new Product
                    {
                        productNumber = resultSet["productNumber"].ToString(),
                        inventoryNumber = resultSet["inventoryNumber"].ToString(),
                        name = resultSet["name"].ToString(),

                        dateAdded = DateTime.Parse(resultSet["dateAdded"].ToString()),

                        count = Convert.ToInt32(resultSet["count"]),
                        price = Convert.ToInt32(resultSet["price"]),

                        availability = Convert.ToBoolean(resultSet["availability"]),
                        delivery = Convert.ToBoolean(resultSet["delivery"]),
                        installation = Convert.ToBoolean(resultSet["installation"])
                    };
                    list.Add(product);
                }
                MySQLConnection.connection.Close();
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
