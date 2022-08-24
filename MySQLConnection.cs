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
        static string connectionString = @"Data Source = localhost; Initial Catalog = CS223labDB; Integrated Security = True";
        public static SqlConnection connection = new(connectionString);
        
        public static int ExecuteNonQuery(string query)
        {

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public static string ExecuteScalar(string query)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            string scalarValue = command.ExecuteScalar().ToString();
            connection.Close();

            return scalarValue;
        }

        public static SqlDataReader ExecuteReader(string query)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }

    }
}
