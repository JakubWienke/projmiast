using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Adres : IInformacje
    { 
        public string Ulica { get; private set; }
        public string Miasto { get; private set; }
        public string KodPocztowy { get; private set; }
        public int NrDomu { get; private set; }

        public Adres()
        {
            this.UstawDane(Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH, 0);
        }

        public Adres(string ulica) : this()
        {
            this.UstawDane(ulica);
        }

        public Adres(string ulica, string miasto) : this()
        {
            this.UstawDane(ulica, miasto);
        }

        public Adres(string ulica, string miasto, string kodPocztowy) : this()
        {
            this.UstawDane(ulica, miasto, kodPocztowy);
        }

        public Adres(string ulica, string miasto, string kodPocztowy, int nrDomu) : this()
        {
            this.UstawDane(ulica, miasto, kodPocztowy, nrDomu);
        }

        public void UstawDane(string ulica)
        {
            if (!string.IsNullOrEmpty(ulica))
                this.Ulica = ulica;
        }

        public void UstawDane(string ulica, string miasto)
        {
            UstawDane(ulica);

            if (!string.IsNullOrEmpty(miasto))
                this.Miasto = miasto;
        }

        public void UstawDane(string ulica, string miasto, string kodPocztowy)
        {
            UstawDane(ulica, miasto);

            if (!string.IsNullOrEmpty(kodPocztowy))
                this.KodPocztowy = kodPocztowy;
        }

        public void UstawDane(int nrDomu)
        {
            this.NrDomu = nrDomu;
        }

        public void UstawDane(string ulica, string miasto, string kodPocztowy, int nrDomu)
        {
            UstawDane(ulica, miasto, kodPocztowy);
            UstawDane(nrDomu);
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("{0} {1}\n{2} {3}", this.Ulica, this.NrDomu, this.KodPocztowy, this.Miasto);
        }
    }
}
