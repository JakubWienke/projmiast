using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    abstract class Kot : Zwierzatko
    {

        public Kot(RodzajZwierzatka zwierz, string imie, int wiek) : base(zwierz, imie, wiek)
        {
        }

        override public string GatunekZwierzatka()
        {
            return "Kot";
        }
        override public abstract string RasaZwierzaka();
        override public void NiechZwierzCosPowie()
        {
            Console.WriteLine("Meow meow");
        }

    }
}
