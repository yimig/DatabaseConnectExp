using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public static class UserManager
    {

        public static List<User> GetUsers(string userName,string userPwd)
        {
            return UserService.searchUser(" and userName=\'"+userName+"\' and userPwd=\'"+userPwd+"\'");
        }

        /// <summary>
        /// 向数据库添加一条用户信息
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>添加是否成功</returns>
        public static bool AddUser(User user)
        {
            if (CheckUserInfo(user)) return ConvertCmdResult(UserService.AddUser(user));
            else return false;
        }

        /// <summary>
        /// 向数据库更新一条用户信息
        /// </summary>
        /// <param name="user">用户信息（id字段必须赋值）</param>
        /// <returns>更新是否成功</returns>
        public static bool UpdateUser(User user)
        {
            if (CheckUserInfo(user)) return ConvertCmdResult(UserService.UpdateUser(user));
            else return false;
        }

        /// <summary>
        /// 在数据库中删除一条用户信息
        /// </summary>
        /// <param name="name">用户id</param>
        /// <returns>删除是否成功</returns>
        public static bool DelUser(string name)
        {
            return ConvertCmdResult(UserService.DelUser(name));
        }

        /// <summary>
        /// 检查输入的用户信息是否符合数据库存储标准
        /// </summary>
        /// <param name="user">要检查的用户信息</param>
        /// <returns>检查结果</returns>
        private static bool CheckUserInfo(User user)
        {
            bool check = true;
            if (user.UserName.Length > 20) check = false;
            else if (!(user.Role==0||user.Role==1)) check = false;
            else if (user.Note.Length > 500) check = false;
            return check;
        }

        /// <summary>
        /// 转换数据库回传的操作结果
        /// </summary>
        /// <param name="result">回传结果</param>
        /// <returns>转换后的操作结果</returns>
        private static bool ConvertCmdResult(int result)
        {
            if (result == 1) return true;
            else return false;
        }
    }
}
