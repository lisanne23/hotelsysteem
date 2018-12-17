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
    }
}
