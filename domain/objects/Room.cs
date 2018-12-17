using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    public class Room
    {
        public int RoomNumber { get; private set; }
        public int GuestLimit { get; private set; }
        

        public Room(int roomNumber, int guestLimit)
        {
            RoomNumber = roomNumber;
            GuestLimit = guestLimit;
        }
    }
}
