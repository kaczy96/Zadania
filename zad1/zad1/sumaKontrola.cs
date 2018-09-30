using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class SumaKontrola
    {
        public double sumaKontrolna(char[] peselArray )
        {
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
            sumakontrolna = sumakontrolna % 10;
            sumakontrolna = 10 - sumakontrolna;
            return sumakontrolna;
        }
    }
}
