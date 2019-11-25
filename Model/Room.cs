using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Room
    {
        private string roomId,roomType,roomFloor,note;
        private double price;
        private int personNum, inPerson;

        public string RoomId
        {
            get => roomId;
            set => roomId = value;
        }

        public string RoomType
        {
            get => roomType;
            set => roomType = value;
        }

        public string RoomFloor
        {
            get => roomFloor;
            set => roomFloor = value;
        }

        public string Note
        {
            get => note;
            set => note = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public int PersonNum
        {
            get => personNum;
            set => personNum = value;
        }

        public int InPerson
        {
            get => inPerson;
            set => inPerson = value;
        }
    }
}