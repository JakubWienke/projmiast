﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    public class Kura : Zwierzatko
    {

        public Kura(RodzajZwierzatka zwierz, string imie, int wiek) : base(zwierz, imie, wiek)
        {
        }

        override public string GatunekZwierzatka()
        {
            return "Kura";
        }
        override public string RasaZwierzaka()
        {
            return "Nieznana";
        }
        override public void NiechZwierzCosPowie()
        {
            Console.WriteLine("Bok bok");
        }

    }
}