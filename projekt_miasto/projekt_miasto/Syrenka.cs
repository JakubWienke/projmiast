using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Syrena : Pojazd
    {
        public Syrena(RodzajPojazdu rodzaj, Silnik silnik, ZbiornikPaliwa zbiornikpaliwa) : base(rodzaj,silnik,zbiornikpaliwa)
        {
        }

        public override string Marka()
        {
            return "Syrena";
        }

        public override string Model()
        {
            return "105";
        }
    }
}
