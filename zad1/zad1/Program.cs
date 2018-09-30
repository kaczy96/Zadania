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

                if(month < 89 && month >= 80)
                {
                    month = month - 80;
                    year = year + 1800;
                }
                else if (month <29 && month >= 20)
                {
                    month = month - 80;
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

                double sumakontrolna =
                    Char.GetNumericValue(peselArray[0]) * 1 +
                    Char.GetNumericValue(peselArray[1]) * 3 +
                    Char.GetNumericValue(peselArray[2]) * 7 +
                    Char.GetNumericValue(peselArray[3]) * 9 +
                    Char.GetNumericValue(peselArray[4]) * 1 +
                    Char.GetNumericValue(peselArray[5]) * 3 +
                    Char.GetNumericValue(peselArray[6]) * 7 +
                    Char.GetNumericValue(peselArray[7]) * 9 +
                    Char.GetNumericValue(peselArray[8]) * 1 +
                    Char.GetNumericValue(peselArray[9]) * 3;
                sumakontrolna =  sumakontrolna % 10;
                sumakontrolna = 10 - sumakontrolna;
                if (sumakontrolna == Char.GetNumericValue(peselArray[10]))
                {
                    if (Char.GetNumericValue(peselArray[9]) % 2 == 0)
                    {
                        Console.WriteLine("Płeć: Kobieta");
                    }
                    else
                    {
                        Console.WriteLine("Płeć: Mężczyzna");
                    }
                    Console.WriteLine("Nr PESEL prawidłowy");
                }
                else
                {
                    Console.WriteLine("Nr PESEL nieprawidłowy");
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
