using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 封装用户信息
    /// </summary>
    public class User
    {
        private string name, address, temp;
        private int id;
        private char gender;
        private DateTime birthday;

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// 用户住址
        /// </summary>
        public string Address
        {
            get => address;
            set => address = value;
        }

        /// <summary>
        /// 附加信息
        /// </summary>
        public string Temp
        {
            get => temp;
            set => temp = value;
        }

        /// <summary>
        /// 用户id
        /// </summary>
        public int Id
        {
            get => id;
            set => id = value;
        }

        /// <summary>
        /// 用户性别（男=0，女=1）
        /// </summary>
        public char Gender
        {
            get => gender;
            set => gender = value;
        }

        /// <summary>
        /// 用户生日
        /// </summary>
        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value;
        }
    }
}
