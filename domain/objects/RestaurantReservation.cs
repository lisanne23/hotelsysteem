using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_HotelSysteem
{
    class RestaurantReservation
    {
        public DateTime Date { get; private set; }
        public Type TypeReservation { get; private set; }

        public RestaurantReservation(DateTime date, Type typeReservation)
        {
            Date = date;
            TypeReservation = typeReservation;
        }
    }


}
