using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Program
    {
        static void Main(string[] args)
        {

            Zwierzyniec.Instancja().DodajZwierzatko(new Labrador(Zwierzatko.RodzajZwierzatka.DOMOWE, "Kepek", 10));
            Zwierzyniec.Instancja().DodajZwierzatko(new Brytyjski(Zwierzatko.RodzajZwierzatka.DOMOWE, "Kep1", 10));
            Zwierzyniec.Instancja().DodajZwierzatko(new Brytyjski(Zwierzatko.RodzajZwierzatka.DOMOWE, "Kep2", 10));
            Zwierzyniec.Instancja().DodajZwierzatko(new Brytyjski(Zwierzatko.RodzajZwierzatka.DOMOWE, "Kep3", 10));
            Zwierzyniec.Instancja().WyswietlInformacje();

            Pojazd DajtamAutko = new Syrena(Pojazd.RodzajPojazdu.OSOBOWY, new Parowy(0,12), new ZbiornikPaliwa(12));
            Adres Adr = new Adres("ul", "miasto", "11-111", 5);

            Osoba osoba = new Osoba("Pan", "Wołodyjowski",Osoba.RodzajPlci.MEZCZYZNA, Adr, "pwol@siekniewicz.pl", 29);
            osoba.WyswietlInformacje();
            osoba.KupPanPojazd(DajtamAutko);
            osoba.Pojazd(0).ZbiornikPaliwa.Dotankuj(6);
            osoba.Pojazd(0).JedziemyWSinaDal(100);
            osoba.WyswietlInformacje();


            osoba.AdoptujZwierza(Zwierzyniec.Instancja().PobierzZwierzatko(0));
            osoba.WyswietlInformacje();
            Zwierzyniec.Instancja().WyswietlInformacje();
        }
    }
}
