using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Osoba : IInformacje
    {
        public enum RodzajPlci 
        {
            MEZCZYZNA   = 0x0001,
            KOBIETA     = 0x0002,
            BRAK_DANYCH = 0x0000
        };

        private List<Pojazd> o_listaPojazdow;
        private List<Zwierzatko> o_listaZwierzatek;
        public string Imie { get;  private set ;}
        public string Nazwisko { get; private set; }
        public RodzajPlci Plec { get; private set; }
        public Adres Adres { get; private set; }
        public string AdresEmail { get; private set; }
        public int Wiek { get; private set; }


        public Osoba()
        {
            this.o_listaPojazdow = new List<Pojazd>();
            this.o_listaZwierzatek = new List<Zwierzatko>();
            this.Plec = RodzajPlci.BRAK_DANYCH;
            this.UstawDane(Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH);
            this.Adres = new Adres();
        }

        public Osoba(string imie, string nazwisko) : this()
        {
            this.UstawDane(imie, nazwisko);
        }

        public Osoba(string imie, string nazwisko, RodzajPlci plec) : this(imie, nazwisko)
        {
            this.Plec = plec;
        }

        public Osoba(string imie, string nazwisko, RodzajPlci plec, Adres adres) : this(imie, nazwisko, plec)
        {
            UstawDane(adres);
        }

        public Osoba(string imie, string nazwisko, RodzajPlci plec, Adres adres, string email) : this(imie, nazwisko, plec, adres)
        {
            UstawDane(email);
        }

        public Osoba(string imie, string nazwisko, RodzajPlci plec, Adres adres, string email, int wiek) : this(imie, nazwisko, plec, adres, email)
        {
            UstawDane(wiek);
        }

        public void UstawDane(string imie, string nazwisko)
        {
            if (!string.IsNullOrEmpty(imie))
                this.Imie = imie;

            if (!string.IsNullOrEmpty(nazwisko))
                this.Nazwisko = nazwisko;
        }

        public void UstawDane(string email, int wiek)
        {
            UstawDane(email);
            UstawDane(wiek);
        }

        public void UstawDane(string imie, string nazwisko, Adres adres)
        {
            UstawDane(imie, nazwisko);
            UstawDane(adres);
        }

        public void UstawDane(string imie, string nazwisko, Adres adres, string email)
        {
            UstawDane(imie, nazwisko, adres);
            UstawDane(email);
        }

        public void UstawDane(string imie, string nazwisko, Adres adres, string email, int wiek)
        {
            UstawDane(imie, nazwisko, adres, email);
            UstawDane(wiek);
        }

        public void UstawDane(Adres adres)
        {
            this.Adres = adres;
        }

        public void UstawDane(string email) 
        {
            if (!string.IsNullOrEmpty(email))
                this.AdresEmail = email;
        }

        public void UstawDane(int wiek)
        {
                this.Wiek = wiek;
        }

        public void UstawDane(RodzajPlci plec)
        {
            this.Plec = plec;
        }

        public static Osoba StworzOsobe()
        {
            Osoba result = new Osoba();

            Console.WriteLine("=== wprowadz dane nowej osoby ===");

            result.UstawDane(Toolbox.inputString("Podaj imie:", true),
                            Toolbox.inputString("Podaj nazwisko:", false));

            result.Adres.UstawDane(Toolbox.inputString("Podaj ulice:", false),
                                  Toolbox.inputString("Podaj miasto:", false),
                                  Toolbox.inputKod("Podaj kod pocztowy:", false),
                                  Toolbox.inputInteger("Podaj nr domu:", 1, int.MaxValue));

            result.UstawDane(Toolbox.inputEmail("Podaj email:", false),
                             Toolbox.inputInteger("Podaj wiek:", 1, int.MaxValue));

            return result;
        }

        public void AdoptujZwierza(Zwierzatko o_zwierzatko)
        {
            o_listaZwierzatek.Add(o_zwierzatko);
        }

        public virtual long KupPanPojazd(Pojazd pojazd)
        {
            o_listaPojazdow.Add(pojazd);
            return o_listaPojazdow.IndexOf(pojazd);
          //  return o_listaPojazdow.Count - 1;
        }
        public virtual Pojazd SprzedajPanPojazd(int indeksPojazdu)
        {
            Pojazd i = o_listaPojazdow.ElementAt(indeksPojazdu);
            o_listaPojazdow.RemoveAt(indeksPojazdu);
            return i;
        }

        public virtual Pojazd Pojazd(int indeksPojazdu)
        {
            return o_listaPojazdow.ElementAt(indeksPojazdu);
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Imie = {0} Nazwisko = {1} Plec = {2}", this.Imie, this.Nazwisko, this.Plec);
            this.Adres.WyswietlInformacje();
            Console.WriteLine("Emmail = {0} Wiek = {1}", this.AdresEmail, this.Wiek);

            foreach (Zwierzatko zwierz in o_listaZwierzatek)
            {
                zwierz.WyswietlInformacje();
                zwierz.NiechZwierzCosPowie();
            }

            foreach (Pojazd pojazd in o_listaPojazdow)
            {
                pojazd.WyswietlInformacje();
            }

            Console.WriteLine();

        }

    }
}
