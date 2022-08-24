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

        static private List<Product> list = new List<Product>();

        static public void Add(Product product)
        {
            string query = "INSERT INTO Product VALUES('" +
                product.productNumber + "', '" +
                product.inventoryNumber + "', '" +
                product.dateAdded + "', '" +
                product.name + "', " +
                product.count + ", " +
                product.price + ", " +
                Convert.ToInt32(product.availability) + ", " +
                Convert.ToInt32(product.delivery) + ", " +
                Convert.ToInt32(product.installation) + ")";
            try
            {
                Console.Write("Hello");
                MySQLConnection.ExecuteNonQuery(query);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        static public void Remove(Product product)
        {
            list.Remove(product);
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
            return list.Find(list => list.name == name);
        }

    }
}
