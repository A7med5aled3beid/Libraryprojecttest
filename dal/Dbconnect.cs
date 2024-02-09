using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Librarypro.dal
{
    class Dbconnect
    {
        public static string connection = ConfigurationManager.ConnectionStrings["Librarypro.Properties.Settings.LibraryConnectionString"].ConnectionString;

        public static SqlConnection conn = new SqlConnection(connection);

        public SqlCommand cmd = new SqlCommand();

        public Dbconnect() 
        {
            openconnection();
        }

        void openconnection() 
        {
            if (conn.State !=ConnectionState.Open)
            {
                conn.Open();
            }
        }
    }
}
