using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Parowy : Silnik
    {

        public Parowy(long liczbaPrzejechanychKilometrow, long pojemnoscSilnika) : base(liczbaPrzejechanychKilometrow, pojemnoscSilnika)
        {
        }

        public Parowy(long pojemnoscSilnika) : base(pojemnoscSilnika)
        {
        }

        override public string TypSilnika()
        {
            return "Parowy";
        }

    }
}
