using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        private static SqlConnection conn;
    
        public static SqlConnection Connection
        {
            get
            {
                if(conn==null)
                {
                    string connStr = ConfigurationManager.ConnectionStrings["HotelConStr"].ConnectionString;
                    conn = new SqlConnection(connStr);
                    conn.Open();
                }
                else if(conn.State== ConnectionState.Closed)
                {
                    conn.Open();
                }
                else if(conn.State==ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }
                return conn;
            }
        }

        public static int ExecuteCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static int ExecuteCommand(string sql,params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }
    }
}
