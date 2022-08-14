using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS223lab
{
    internal class Product
    {
        public string productNumber { get; set; }
        public string inventoryNumber { get; set; }
        public DateTime dateAdded { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public bool availability { get; set; }
        public bool delivery { get; set; }
        public bool installation { get; set; }

        static private List<Product> list = new List<Product>();

        static public void save(Product product)
        {
            list.Add(product);
        }

        static public List<Product> GetAllProducts()
        {
            return list;
        }

        public static Product findByName(string name)
        {
            return list.Find(list => list.name == name);
        }

    }
}
