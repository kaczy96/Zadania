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
                if(pesel.Length > 11)
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
                Date monthdate = new Date();
                Date yeardate = new Date();

                if(month < 89 && month >= 80)
                {
                    monthdate.month(month, 80);
                    monthdate.year(year, 1800);
                }
                else if (month <29 && month >= 20)
                {
                    monthdate.month(month, 20);
                    monthdate.year(year, 2000);
                }
                else if (month < 12 && month >= 01)
                {
                    monthdate.month(month, 0);
                    monthdate.year(year, 1900);
                }
                else if (month < 49 && month >= 40)
                {
                    monthdate.month(month, 40);
                    monthdate.year(year, 2100);
                }
                else if (month < 69 && month >= 60)
                {
                    monthdate.month(month, 60);
                    monthdate.year(year, 2200);
                }

                double day = (Char.GetNumericValue(peselArray[4])) * 10 + (Char.GetNumericValue(peselArray[5]));

                if(month < 10 && day < 10)
                {
                    Console.WriteLine("Data urodzenia: {0}-0{1}-0{2}", year, month, day);
                }
                else if (month < 10)
                {
                    Console.WriteLine("Data urodzenia: {0}-0{1}-{2}", year, month, day);
                }
                else if (day < 10)
                {
                    Console.WriteLine("Data urodzenia: {0}-{1}-0{2}", year, month, day);
                }
                else
                {
                    Console.WriteLine("Data urodzenia: {0}-{1}-{2}", year, month, day);
                }

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
