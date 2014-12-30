using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum = 0;
            for (int i = 1; i < 1000; i++) {
                if (i%3 == 0 || i%5 == 0)
                {
                    acum += i;
                    Console.WriteLine("Current num: " + i + " Acumulator: " + acum);
                }
            }
            Console.ReadLine();
        }
    }
}
