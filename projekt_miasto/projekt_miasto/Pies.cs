using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    abstract class Pies: Zwierzatko
    {
        public Pies(RodzajZwierzatka zwierz, string imie, int wiek) : base(zwierz, imie, wiek)
        {
        }

        override public string GatunekZwierzatka()
        {
            return "Pies";
        }
        override public abstract string RasaZwierzaka();
        override public void NiechZwierzCosPowie()
        {
            Console.WriteLine("Woof woof");
        }

    }
}
