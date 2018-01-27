using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class ZbiornikPaliwa : IInformacje
    {
        public long MaksymalnaIloscPaliwa { get; private set; }
        public long IloscPaliwa { get; private set; }


        public ZbiornikPaliwa(long maks)
        {
            this.MaksymalnaIloscPaliwa = maks;
            IloscPaliwa = 0;
        }

        public ZbiornikPaliwa(long maks, long ilosc) : this(maks)
        {
            this.IloscPaliwa = ilosc;
        }

        public void Dotankuj(long iloscPaliwa)
        {
            if (iloscPaliwa > 1)
                if (this.IloscPaliwa + iloscPaliwa < this.MaksymalnaIloscPaliwa)
                    this.IloscPaliwa += iloscPaliwa;
        }

        public long Pobierz(long iloscPaliwa)
        {
            if (iloscPaliwa > 1)
                if (this.IloscPaliwa - iloscPaliwa >= 0)
                    this.IloscPaliwa -= iloscPaliwa;
            return this.IloscPaliwa;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Maksymalna Ilosc Paliwa = {0} Ilosc Paliwa = {1}", this.MaksymalnaIloscPaliwa, this.IloscPaliwa);
        }

    }
}
