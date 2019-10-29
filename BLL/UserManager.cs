using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public static class UserManager
    {
        public static bool AddUser(User user)
        {
            if (CheckUserInfo(user)) return ConvertCmdResult(TableManager.AddUser(user));
            else return false;
        }

        public static bool UpdateUser(User user)
        {
            if (CheckUserInfo(user)) return ConvertCmdResult(TableManager.UpdateUser(user));
            else return false;
        }

        public static bool DelUser(int id)
        {
            return ConvertCmdResult(TableManager.DelUser(id));
        }

        private static bool CheckUserInfo(User user)
        {
            bool check = true;
            if (user.Name.Length > 50) check = false;
            else if (user.Address.Length > 100) check = false;
            else if (user.Temp.Length > 200) check = false;
            else if (!(user.Gender == '1' || user.Gender == '0')) check = false;
            return check;
        }

        private static bool ConvertCmdResult(int result)
        {
            if (result == 1) return true;
            else return false;
        }
    }
}
