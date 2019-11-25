using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        private string userName, userPwd, note;
        private int role;

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        public string UserPwd
        {
            get => userPwd;
            set => userPwd = value;
        }

        public string Note
        {
            get => note;
            set => note = value;
        }

        public int Role
        {
            get => role;
            set => role = value;
        }
    }
}
