﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Miasto
    {
        private static Miasto o_instancja = null;

        private List<Osoba> listaOsob;

        public static Miasto Instacja()
        {
            if (Miasto.o_instancja == null)
            {
                Miasto.o_instancja = new Miasto();
            }
            return Miasto.o_instancja;
        }

        public Miasto()
        {
            this.listaOsob = new List<Osoba>();
        }

        public void uzupelnijMiasto()
        {
            Console.WriteLine("Wybierz: chcesz wprowadzic dane mieskancow - M, chcesz wprowadzic dane zwierzat - Z, koniec programu - K)");

            string s = Console.ReadLine().ToUpper();

            switch (s)
            {
                case "Z":
                    Console.WriteLine("Wprowadz dane Zwierzat");


                    while (true)
                    {
                        //dodaj zwierzatko (zwierzyniec)

                        Console.WriteLine("Czy chcesz wprowadzic kolejne zwierze (T/N)");

                        if (Console.ReadLine().ToUpper() == "N")
                        {
                            break;
                        }
                    }
                    break;

                case "M":
                    Console.WriteLine("Wprowadz dane mieszkancow");

                    while (true)
                    {
                        listaOsob.Add(Osoba.StworzOsobe());

                        Console.WriteLine("Czy chcesz wprowadzic kolejna osobe (T/N)");

                        if (Console.ReadLine().ToUpper() == "N")
                        {
                            break;
                        }
                    }
                    break;

                case "K":
                        while (true)
                    {
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Wprowadzona zla wartosc");
                    break;
            }
        }

        public void wyswietlDaneOsob()
        {
            for (int i = 0; i < listaOsob.Count; ++i)
            {
                Console.WriteLine(i + " - " + listaOsob[i].Imie + "  " + listaOsob[i].Nazwisko);
            }
        }

        public Osoba pobierzOsobe(int index)
        {
            if (index > -1 && index < listaOsob.Count)
                return listaOsob[index];

            return new Osoba();
            }
    }
}
