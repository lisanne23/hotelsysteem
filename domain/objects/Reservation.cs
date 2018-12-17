using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    class Reservation
    {
        public Guest Guest { get; private set; }
        public int AmountPeople { get; private set; }

        public Reservation(Guest guest, int amountPeople)
        {
            Guest = guest;
            AmountPeople = amountPeople;
        }
    }
}
