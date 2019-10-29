using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public static class TableManager
    {
        public static int AddUser(User user)
        {
            return DBHelper.ExecuteCommand($"insert into hotel.dbo.t_user(name,gender,address,birthday,temp) values('{user.Name}', '{user.Gender}', '{user.Address}', '{user.Birthday}', '{user.Temp}');");
        }

        public static int UpdateUser(User user)
        {
            return DBHelper.ExecuteCommand($"update hotel.dbo.t_user set name='{user.Name}',gender='{user.Gender}',address='{user.Address}',birthday='{user.Birthday}',temp='{user.Temp}' where id={user.Id};");
        }

        public static int DelUser(int id)
        {
            return DBHelper.ExecuteCommand("delete from hotel.dbo.t_user where id = " + id);
        }
    }
}
