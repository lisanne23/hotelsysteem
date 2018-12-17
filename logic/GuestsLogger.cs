using domain.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public static class GuestsLogger
    {
        public static List<Guest> Guests { get; private set; }
        public static void init()
        {
            Guests = new List<Guest>();
        }

        public static void addUser(string Name) {
            Guests.Add(new Guest(Name));
        }
    }
}
