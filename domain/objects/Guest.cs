using domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    public class Guest
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public DateTime BirthDate { get; private set; }
        public AcceptedGender AcceptedGender { get; private set; }

        public Guest(string name)
        {
            Name = name;
        }

        public Guest(string name, string adress, DateTime birthDate, AcceptedGender acceptedGender)
        {
            Name = name;
            Adress = adress;
            BirthDate = birthDate;
            AcceptedGender = acceptedGender;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
