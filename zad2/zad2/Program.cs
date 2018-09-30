using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wprowadź wartość z jakiej chcesz obliczyć silnię: ");
            line:
            try
            {
                int silnia = Int32.Parse(Console.ReadLine());
                
                if (silnia == 0)
                    Console.WriteLine("Wynik: 1");
                else
                {
                    //sposób iteracyjny
                    int wynikIteracja = 1;
                    for (int i = 1; i <= silnia; i++)
                    {
                        wynikIteracja *= i;
                    }

                    //sposób rekurencyjny
                    Silnia silniaRek = new Silnia();
                    int wynikRekurencja = silniaRek.silniaRekurencyjnie(silnia);

                    Console.WriteLine("Wynik: {0}", wynikIteracja);
                    Console.WriteLine("Wynik: {0}", wynikRekurencja);
                }
            }
            catch
            {
                Console.WriteLine("Wprowadź poprawną wartość");
                goto line;
            }
            
            
            
            Console.ReadKey();
        }
    }
}
