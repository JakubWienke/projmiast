using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Diesel : Silnik
    {
 
        public Diesel(long liczbaPrzejechanychKilometrow, long pojemnoscSilnika) : base(liczbaPrzejechanychKilometrow, pojemnoscSilnika)
        {
        }

        public Diesel(long pojemnoscSilnika) : base(pojemnoscSilnika)
        {
        }

        override public string TypSilnika()
        {
            return "Diesel";
        }

    }
}
