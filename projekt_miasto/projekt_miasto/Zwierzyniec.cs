using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Zwierzyniec : IInformacje
    {
        private static Zwierzyniec o_instancja;
        private List<Zwierzatko> o_listaZwierzatek;

        private Zwierzyniec()
        {
            o_listaZwierzatek = new List<Zwierzatko>();
        }

        public static Zwierzyniec Instancja()
        {
            if (o_instancja == null)
                {
                o_instancja = new Zwierzyniec();
                }
            return o_instancja;
        }

        public Zwierzatko DodajZwierzatko(Zwierzatko o_zwierzatko)
        {
            o_listaZwierzatek.Add(o_zwierzatko);
            return o_listaZwierzatek.Last();
        }

        public Zwierzatko PobierzZwierzatko(int i_indeksZwierzatka)
        {
            Zwierzatko i = o_listaZwierzatek.ElementAt(i_indeksZwierzatka);
            o_listaZwierzatek.RemoveAt(i_indeksZwierzatka);
            return i;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine();
            Console.WriteLine("============ DANE ZWIERZYNCA =========");

            for(int i = 0 ; i < o_listaZwierzatek.Count();i++)
            {
                Console.WriteLine("Index: " + i);
                o_listaZwierzatek[i].WyswietlInformacje();
                Console.WriteLine();
            }
        }
    }
}
