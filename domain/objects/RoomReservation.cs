using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    public class RoomReservation : Reservation
    {
        public Room Room { get; private set; }

        public RoomReservation(IEnumerable<Guest> guests, Room room) : base(guests)
        {
            Room = room;
        }
    }
}
