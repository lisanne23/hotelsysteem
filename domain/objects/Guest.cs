using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    class Guest
    {
        public string  Name { get; private set; }
        public string  Adress { get; private set; }
        public DateTime BirthData { get; private set; }
        public bool Gender { get; private set; }

        public Guest(string name, string adress, DateTime birthData, bool gender)
        {
            Name = name;
            Adress = adress;
            BirthData = birthData;
            Gender = gender;
        }
    }

}
