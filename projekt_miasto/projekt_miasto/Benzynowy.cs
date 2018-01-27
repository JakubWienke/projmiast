using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Benzynowy : Silnik
    {

        public Benzynowy(long liczbaPrzejechanychKilometrow, long pojemnoscSilnika) : base(liczbaPrzejechanychKilometrow, pojemnoscSilnika)
        {
        }

        public Benzynowy(long pojemnoscSilnika) : base(pojemnoscSilnika)
        {
        }

        override public string TypSilnika()
        {
            return "Benzynowy";
        }

    }
}
