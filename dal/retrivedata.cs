using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Librarypro.dal
{
    class retrivedata
    {
        public static SqlConnection con = new SqlConnection(Dbconnect.connection);
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        public static DataTable execute(string text,CommandType com) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = com;
            cmd.CommandText = text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        public static DataTable execute(string text, CommandType com,params paramter[] paramarr )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = com;
            cmd.CommandText = text;

            foreach (paramter prm in paramarr)
            {
                cmd.Parameters.Add(prm.pname, prm.ptype).Value = prm.pvalue;
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        public static void executenonquary(string text, params paramter[] paramarr) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = text;

            foreach (paramter prm in paramarr)
            {
                cmd.Parameters.Add(prm.pname, prm.ptype).Value = prm.pvalue;
            }
                        try
                        {
                            if (con.State==ConnectionState.Closed )
                            {
                                con.Open();
                            }
                            cmd.ExecuteNonQuery();
                        }
                        catch 
                        {
                            con.Close();
               
                        }
            
        } 
    }
    //*************************************************************************************************************   
    public class paramter 
    {
        public string pname;
        public SqlDbType ptype;
        public object pvalue;

        public  paramter(string pname,SqlDbType ptype,object pvalue) 
        {
            this.pname = pname;
            this.ptype = ptype;
            this.pvalue = pvalue;
        }
    }
}
