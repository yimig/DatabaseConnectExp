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
    /// <summary>
    /// 封装与数据库直接联系方法
    /// </summary>
    public class DBHelper
    {
        private static SqlConnection conn;
    
        /// <summary>
        /// 取得一条可用链接
        /// </summary>
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

        /// <summary>
        /// 执行带有参数的sql指令
        /// </summary>
        /// <param name="sql">SQL指令</param>
        /// <param name="values">参数</param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql,params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }
    }
}
