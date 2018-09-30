using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class DateRegulation
    {
        public void yearRegulation (double day, double month, double year)
        {
            if (month < 10 && day < 10)
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
    }
}
