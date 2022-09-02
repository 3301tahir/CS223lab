using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CS223lab
{
    internal class MySQLConnection
    {
        // Public field accessed when creating connections
        // Is there a better implementation?
        public static string connString = @"Data Source = localhost; Initial Catalog = CS223labDB; Integrated Security = True";

        // Called after user logins
        public static bool CheckConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
