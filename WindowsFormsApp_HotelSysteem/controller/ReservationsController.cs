using domain.objects;
using logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_HotelSysteem.controller
{
    public static class ReservationsController
    {
        public static void AddUser(string name){
            GuestsLogger.addUser(name);
        }

        public static IEnumerable<Guest> GetGuests() { return GuestsLogger.Guests; }
    }
}
