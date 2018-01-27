using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Labrador : Pies
    {
        public Labrador(RodzajZwierzatka zwierz, string imie, int wiek) : base(zwierz, imie, wiek)
        {
        }

        override public string RasaZwierzaka()
        {
            return "Labrador";
        }

    }
}
