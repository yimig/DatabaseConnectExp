using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    /// <summary>
    /// 封装操作用户信息的方法
    /// </summary>
    public static class UserManager
    {
        /// <summary>
        /// 向数据库添加一条用户信息
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>添加是否成功</returns>
        public static bool AddUser(User user)
        {
            if (CheckUserInfo(user)) return ConvertCmdResult(TableManager.AddUser(user));
            else return false;
        }

        /// <summary>
        /// 向数据库更新一条用户信息
        /// </summary>
        /// <param name="user">用户信息（id字段必须赋值）</param>
        /// <returns>更新是否成功</returns>
        public static bool UpdateUser(User user)
        {
            if (CheckUserInfo(user)) return ConvertCmdResult(TableManager.UpdateUser(user));
            else return false;
        }

        /// <summary>
        /// 在数据库中删除一条用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>删除是否成功</returns>
        public static bool DelUser(int id)
        {
            return ConvertCmdResult(TableManager.DelUser(id));
        }

        /// <summary>
        /// 检查输入的用户信息是否符合数据库存储标准
        /// </summary>
        /// <param name="user">要检查的用户信息</param>
        /// <returns>检查结果</returns>
        private static bool CheckUserInfo(User user)
        {
            bool check = true;
            if (user.Name.Length > 50) check = false;
            else if (user.Address.Length > 100) check = false;
            else if (user.Temp.Length > 200) check = false;
            else if (!(user.Gender == '1' || user.Gender == '0')) check = false;
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
