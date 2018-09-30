using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Wprowadź swój nr PESEL");
            try
            {
                

                string pesel = Console.ReadLine();

                double num;
                bool isNum = double.TryParse(pesel, out num);
                if(!isNum)
                {
                    Console.Clear();
                    Console.WriteLine("Niepoprawny nr PESEL");
                    goto start;
                }
        
                if (pesel.Length > 11)
                {
                    Console.Clear();
                    Console.WriteLine("Podany nr PESEL jest za długi");
                    goto start;
                }
                else if(pesel.Length < 11)
                {
                    Console.Clear();
                    Console.WriteLine("Podany nr PESEL jest za krótki");
                    goto start;
                }

                char[] peselArray = new char[11];
                peselArray = pesel.ToCharArray();
                string peselDisplay = new string(peselArray);
                Console.Clear();
                Console.WriteLine("Nr PESEL: {0}", peselDisplay);

                double year = (Char.GetNumericValue(peselArray[0])) * 10 + (Char.GetNumericValue(peselArray[1]));
                double month = (Char.GetNumericValue(peselArray[2])) * 10 + (Char.GetNumericValue(peselArray[3]));

                #region
                if (month < 89 && month >= 80)
                {
                    month = month - 80;
                    year = year + 1800;
                }
                else if (month < 29 && month >= 20)
                {
                    month = month - 20;
                    year = year + 2000;
                }
                else if (month < 12 && month >= 01)
                {
                    year = year + 1900;
                }
                else if (month < 49 && month >= 40)
                {
                    month = month - 40;
                    year = year + 2100;
                }
                else if (month < 69 && month >= 60)
                {
                    month = month - 60;
                    year = year + 2200;
                }
                #endregion
                double day = (Char.GetNumericValue(peselArray[4])) * 10 + (Char.GetNumericValue(peselArray[5]));

                DateRegulation regulacjaDMR = new DateRegulation();
                regulacjaDMR.yearRegulation(day,month, year);

                SumaKontrola sumakontrolna = new SumaKontrola();
                double sk = sumakontrolna.sumaKontrolna(peselArray);

                int kontrola = 0;
                Validation weryfikacja = new Validation();
                weryfikacja.validation(kontrola, sk, peselArray);

            }

            catch
            {
                Console.WriteLine("Nieprawidłowy nr PESEL");
                goto start;
            }

            

        

            Console.ReadKey();
        }
    }
}
