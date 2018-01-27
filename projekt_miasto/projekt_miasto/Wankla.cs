using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Wankla : Silnik
    {

        public Wankla(long liczbaPrzejechanychKilometrow, long pojemnoscSilnika) : base(liczbaPrzejechanychKilometrow, pojemnoscSilnika)
        {
        }

        public Wankla(long pojemnoscSilnika) : base(pojemnoscSilnika)
        {
        }

        override public string TypSilnika()
        {
            return "Wankla";
        }

    }
}
