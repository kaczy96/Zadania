using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Silnia
    {
        public int  silniaRekurencyjnie (int n)
        {
            if (n==0)
            {
                return 1;
            }
            else
            {
                return n * silniaRekurencyjnie(n - 1);
            }
        }
    }
}
