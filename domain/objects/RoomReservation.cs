using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_HotelSysteem
{
    class RoomReservation
    {
        public Room room { get; private set; }
        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public RoomReservation(Room room, DateTime startDate, DateTime endDate)
        {
            this.room = room;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
