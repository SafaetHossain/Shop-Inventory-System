using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    class DataAccess
    {
        static SqlConnection conn;

        static SqlConnection Connection
        {
            get
            {
                conn = new SqlConnection(ShopInventorySystem.Data.Properties.Settings.Default.databaseConnectionString);
                conn.Open();
                return conn;
            }
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query,Connection);
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query,Connection);
            return cmd.ExecuteReader();
        }
    }
}
