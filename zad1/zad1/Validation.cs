using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Validation
    {
        public void validation (int kontrola, double sk, char[] peselArray)
        {
            if (sk == Char.GetNumericValue(peselArray[10]))
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
    }
}
