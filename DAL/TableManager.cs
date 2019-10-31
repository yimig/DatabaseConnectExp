using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    /// <summary>
    /// 封装操作数据库的方法
    /// </summary>
    public static class TableManager
    {
        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>指令运行结果</returns>
        public static int AddUser(User user)
        {
            return DBHelper.ExecuteCommand($"insert into hotel.dbo.t_user(name,gender,address,birthday,temp) values('{user.Name}', '{user.Gender}', '{user.Address}', '{user.Birthday}', '{user.Temp}');");
        }

        /// <summary>
        /// 更新一个用户信息
        /// </summary>
        /// <param name="user">用户信息（id字段必须赋值）</param>
        /// <returns>指令运行结果</returns>
        public static int UpdateUser(User user)
        {
            return DBHelper.ExecuteCommand($"update hotel.dbo.t_user set name='{user.Name}',gender='{user.Gender}',address='{user.Address}',birthday='{user.Birthday}',temp='{user.Temp}' where id={user.Id};");
        }

        /// <summary>
        /// 删除一个用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>指令运行结果</returns>
        public static int DelUser(int id)
        {
            return DBHelper.ExecuteCommand("delete from hotel.dbo.t_user where id = " + id);
        }
    }
}
