using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    abstract class Pojazd : IInformacje
    {
        public enum RodzajPojazdu
        {
            JEDNOSLAD = 0x0001,
            OSOBOWY = 0x0002,
            TERENOWY = 0x0003,
            CIEZAROWY = 0x0004,
            BRAK_DANYCH = 0x0000
        };

        public ZbiornikPaliwa ZbiornikPaliwa { get; private set; }
        public Silnik Silnik { get; private set; }
        public RodzajPojazdu Rodzaj { get; private set; }

        public Pojazd(RodzajPojazdu rodzaj, Silnik silnik)
        {
            this.Rodzaj = rodzaj;
            this.Silnik = silnik;
            this.ZbiornikPaliwa = new ZbiornikPaliwa(12);
        }

        public Pojazd(RodzajPojazdu rodzaj, Silnik silnik, ZbiornikPaliwa zbiornikpaliwa) : this(rodzaj,silnik)
        {
            this.ZbiornikPaliwa = zbiornikpaliwa;
        }

        //tutaj jak zwykle powinny znaleźć się odpowiednie konstruktory - proszę zbudować je sprytnie, pytanie czy tutaj musimy już inicjować obiekty ZbiornikPaliwa i Silnik, czy zrobić to np. w klasach potomnych

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine("Rodzaj Pojazdu = {0} Marka = {1} Model = {2}", this.Rodzaj, this.Marka(), this.Model());
            ZbiornikPaliwa.WyswietlInformacje();
            Silnik.WyswietlInformacje();
            
        }
        //ta metoda wyświetli informację o pojezdzie

        public abstract string Marka();
        public abstract string Model();

        public virtual long JedziemyWSinaDal(long liczbaKilometrow)
        {
            return Silnik.JedziemyWSinaDal(liczbaKilometrow, this.ZbiornikPaliwa);
        }
        
        //metoda powinna odwołać się do obiektu Silnik i odpowiednio na nim zadziałać by przejechać zadaną liczbę kilometrów
    }
}
