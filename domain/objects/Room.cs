using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    class Room
    {
        public int Number { get; private set; }
        public int Guestlimit { get; private set; }

        public Room(int number, int guestlimit)
        {
            Number = number;
            Guestlimit = guestlimit;
        }
    }
}
