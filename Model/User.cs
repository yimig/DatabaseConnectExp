using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private string name, address, temp;
        private int id;
        private char gender;
        private DateTime birthday;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Temp
        {
            get => temp;
            set => temp = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public char Gender
        {
            get => gender;
            set => gender = value;
        }

        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value;
        }
    }
}
