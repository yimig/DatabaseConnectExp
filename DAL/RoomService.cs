using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class RoomService
    {
        public static List<Room> searchRooms(string where)
        {
            string sql = "select * from room where 1=1 " + where;
            SqlDataReader dr= DBHelper.ExecuteQuery(sql);
            List<Room> l=new List<Room>();
            Room temp;
            while (dr.Read())
            {
                temp=new Room();
                temp.RoomId = dr["roomId"].ToString();
                temp.RoomType = dr["roomType"].ToString();
                temp.RoomFloor = dr["roomFloor"].ToString();
                temp.Price = Convert.ToDouble(dr["price"].ToString());
                temp.PersonNum = Convert.ToInt32(dr["PersonNum"].ToString());
                temp.InPerson = Convert.ToInt32(dr["inPerson"].ToString());
                temp.Note = dr["note"].ToString();
                l.Add(temp);
            }
            dr.Close();
            DBHelper.CloseConnection();
            return l;
        }
    }
}
