using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    public class Kon : Zwierzatko
    {
        public Kon(RodzajZwierzatka zwierz, string imie, int wiek) : base(zwierz, imie, wiek)
        {
        }

        override public string GatunekZwierzatka()
        {
            return "Kon";
        }
        override public string RasaZwierzaka()
        {
            return "Nieznana";
        }
        override public void NiechZwierzCosPowie()
        {
            Console.WriteLine("Neigh");
        }

    }
}
