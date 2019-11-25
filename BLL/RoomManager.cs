using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class RoomManager
    {
        public static List<Room> searchByRoomType(string roomType)
        {
            string sql = "and roomType='" + roomType + "'";
            return RoomService.searchRooms(sql);
        }

        public static List<Room> searchEmptyRoom()
        {
            string sql = "and inPerson=0";
            return RoomService.searchRooms(sql);
        }

        public static List<Room> searchByPrice(double price)
        {
            string sql = "and price<=" + price;
            return RoomService.searchRooms(sql);
        }

        public static Room searchById(string roomId)
        {
            string sql = "and roomId='" + roomId + "'";
            List<Room> rooms = RoomService.searchRooms(sql);
            if (rooms != null)
            {
                return rooms[0];
            }
            else return null;
        }

    }
}
