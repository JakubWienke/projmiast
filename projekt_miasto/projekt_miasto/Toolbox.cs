using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace projekt_miasto
{
    class Toolbox
    {
        public static string BRAK_DANYCH = "Brak danych";

        public static int inputInteger(string inputText,int min, int max)
        {
            int result = 0;

            while (true)
            {
                string liczba = Toolbox.inputString(inputText, false);

                //result = int.Parse(liczba);

                if (!int.TryParse(liczba, out result) ||
                    (result < min || result > max))
                {
                    Console.WriteLine("Wprowadzono niepoprawna wartosc (Zakres {0} {1})", min, max);
                }
                else
                    break;        
            }
            
            return result;
        }

        public static string inputString(string inputText, bool isEmpty)
        {
            string result = "";

            while(true)
            {
                Console.Write(inputText);
                result = Console.ReadLine();

                if (isEmpty)
                {
                    break;
                }                    
                else
                    if (string.IsNullOrEmpty(result))
                    {   
                        Console.WriteLine("Wartosc nie moze byc pusta!");
                    }
                    else
                    // if (!CheckLetters(result))
                    //{   
                    //    Console.WriteLine("Wprowadzone dane musza sie zaczynaz z duzej litero oraz nie posiadac cyfr");
                    //}
                    //else
                        break;
            }

            return result;
        }

        public static bool CheckPostalCode(string inputText)
        {
            string kod = @"^[0-9]{2}-[0-9]{3}$";

            Regex r = new Regex(kod);

            Match n = r.Match(inputText);

            return n.Success;

        }

        public static bool CheckEmail(string inputText)
        {
            string email = @"^[a-zA-Z0-9\_]+@+[a-zA-Z0-9\_]+.+[a-zA-Z0-9\_]$";

            Regex k = new Regex(email);

            Match s = k.Match(inputText);

            return s.Success;

        }

        public static bool CheckLetters(string inputText)
        {
            string kod = @"^[A-Z][a-z]+$";

            Regex r = new Regex(kod);

            Match n = r.Match(inputText);

            return n.Success;
        }

        public static string inputKod(string inputText, bool isEmpty)
        {
            string result = "";

            while (true)
            {
                Console.Write(inputText);
                result = Console.ReadLine();

                if (isEmpty)
                {
                    break;
                }
                else
                    if (!CheckPostalCode(result)) 
                {
                    Console.WriteLine("Wartosc nie odpowiada poprawnemu kodowi pocztowemu");
                }
                else
                    break;
            }

            return result;
        }

        public static string inputEmail(string inputText, bool isEmpty)
        {
            string result = "";

            while (true)
            {
                Console.Write(inputText);
                result = Console.ReadLine();

                if (isEmpty)
                {
                    break;
                }
                else
                    if (!CheckEmail(result))
                {
                    Console.WriteLine("Wartosc nie odpowiada poprawnemu emailowi");
                }
                else
                    break;
            }

            return result;
        }
    }
}
