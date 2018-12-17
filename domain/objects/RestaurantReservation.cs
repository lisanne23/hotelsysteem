using domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    public class RestaurantReservation : Reservation
    {
        public DateTime Date { get; private set; }
        public LunchType LunchType { get; private set; }

        public RestaurantReservation(IEnumerable<Guest> guests, DateTime date, LunchType lunchType) : base(guests)
        {
            Date = date;
            LunchType = lunchType;
        }
    }
}
