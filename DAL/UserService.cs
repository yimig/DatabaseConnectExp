using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public static class UserService
    {
        public static List<User> searchUser(string where)
        {
            string sql = "select * from UserDetails where 1=1" + where;
            SqlDataReader dr = DBHelper.ExecuteQuery(sql);
            List<User> users=new List<User>();
            User temp;
            while (dr.Read())
            {
                temp=new User();
                temp.UserName = dr["userName"].ToString();
                temp.UserPwd = dr["userPwd"].ToString();
                temp.Role = Convert.ToInt32(dr["role"].ToString());
                temp.Note = dr["note"].ToString();
                users.Add(temp);
            }
            dr.Close();
            DBHelper.CloseConnection();
            return users;
        }

        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>指令运行结果</returns>
        public static int AddUser(User user)
        {
            return DBHelper.ExecuteCommand($"insert into hotel.dbo.UserDetails(userName,userPwd,role,note) values('{user.UserName}', '{user.UserPwd}', '{user.Role}', '{user.Note}')");
        }

        /// <summary>
        /// 更新一个用户信息
        /// </summary>
        /// <param name="user">用户信息（id字段必须赋值）</param>
        /// <returns>指令运行结果</returns>
        public static int UpdateUser(User user)
        {
            return DBHelper.ExecuteCommand($"update hotel.dbo.UserDetails set userName='{user.UserName}',userPwd='{user.UserPwd}',role='{user.Role}',note='{user.Note}' where userName='{user.UserName}'");
        }

        /// <summary>
        /// 删除一个用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>指令运行结果</returns>
        public static int DelUser(string name)
        {
            return DBHelper.ExecuteCommand("delete from hotel.dbo.UserDetails where userName = '" + name+"'");
        }
    }
}
