using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    public class Reservation
    {
        public IEnumerable<Guest> Guests { get; private set; }

        public Reservation(IEnumerable<Guest> guests)
        {
            Guests = guests;
        }
    }
}
