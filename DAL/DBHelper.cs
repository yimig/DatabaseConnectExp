using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        private static SqlConnection conn = null;

        public static SqlConnection Connection
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["HotelSqlConn"].ConnectionString;
                    conn.Open();
                }
                else if(conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                else if (conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }

                return conn;
            }
        }

        public static SqlDataReader ExecuteQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = sql;
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// 执行数据库sql指令
        /// </summary>
        /// <param name="sql">sql指令</param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            return cmd.ExecuteNonQuery();
        }


        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
