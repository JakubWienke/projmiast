using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    public abstract class Zwierzatko : IInformacje
    {
        public enum RodzajZwierzatka
        {
            DOMOWE = 0x0001,
            HODOWLANE = 0x0002,
            BRAK_DANYCH = 0x0000
        };

        public string Imie { get; private set; }
        public int Wiek { get; private set; }
        public RodzajZwierzatka Zwierz { get; private set; }

        public Zwierzatko()
        {
            this.UstawDane(Toolbox.BRAK_DANYCH);
            this.Wiek = 0;
            this.Zwierz = RodzajZwierzatka.BRAK_DANYCH;
        }

        public Zwierzatko(RodzajZwierzatka zwierz)
        {
            this.Zwierz = zwierz;
        }

        public Zwierzatko(RodzajZwierzatka zwierz, string imie) : this(zwierz)
        {
            UstawDane(imie);
        }

        public Zwierzatko(RodzajZwierzatka zwierz, string imie, int wiek) : this(zwierz, imie)
        {
            UstawDane(wiek);
        }

        public void UstawDane(string imie)
        {
            if (!string.IsNullOrEmpty(imie))
                this.Imie = imie;
        }

        public void UstawDane(int wiek)
        {
                this.Wiek = wiek;
        }


        public void UstawDane(string imie, int wiek)
        {
            UstawDane(imie);
            UstawDane(wiek);
        }


        public abstract string GatunekZwierzatka();
        public abstract string RasaZwierzaka();
        public abstract void NiechZwierzCosPowie();

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Rodzaj Zwierzecia = {0} Imie = {1}  Wiek = {2} Rasa = {3} Gatunek = {4}", this.Zwierz, this.Imie, this.Wiek,this.RasaZwierzaka(),this.GatunekZwierzatka());
        }
    }
}
