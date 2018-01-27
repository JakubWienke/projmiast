using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    abstract class Silnik : IInformacje
    {
        public long LiczbaPrzejechanychKilometrow { get; private set; }
        public long PojemnoscSilnika { get; private set; }

        public Silnik(long pojemnoscSilnika)
        {
            this.LiczbaPrzejechanychKilometrow = 0;
            this.PojemnoscSilnika = pojemnoscSilnika;
        }

        public Silnik(long liczbaPrzejechanychKilometrow, long pojemnoscSilnika) : this(pojemnoscSilnika)
        {
            this.LiczbaPrzejechanychKilometrow = liczbaPrzejechanychKilometrow;
        }

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Liczba Przejechanych Kilometrow = {0} Pojemnosc Silnika = {1} Typ Silnika = {2}", this.LiczbaPrzejechanychKilometrow, this.PojemnoscSilnika, this.TypSilnika());
        }

        public virtual long JedziemyWSinaDal(long liczbaKilometrow, ZbiornikPaliwa zbiornikPaliwa)
        {
            long maxliczbaKilometrow = (long)(((float) zbiornikPaliwa.IloscPaliwa /(float) PojemnoscSilnika) * 100);

            if (liczbaKilometrow > maxliczbaKilometrow)
            {
                zbiornikPaliwa.Pobierz(zbiornikPaliwa.IloscPaliwa);
                LiczbaPrzejechanychKilometrow += maxliczbaKilometrow;
                return maxliczbaKilometrow;
            }
            else
            {
                long IloscZuzytegoPaliwa = (long)((float)(PojemnoscSilnika * liczbaKilometrow) / 100f);
                zbiornikPaliwa.Pobierz(IloscZuzytegoPaliwa);
                LiczbaPrzejechanychKilometrow += liczbaKilometrow;
                return liczbaKilometrow;
            }

        }

        public abstract string TypSilnika();
        	
    }
}
