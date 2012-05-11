using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler2
{
    class Program
    {
        static void Main(string[] args)
        {
            var var1 = 1;
            var var2 = 1;
            var acum = var1 + var2;

            for (int i = 1; i <= 4000000; i++)
            {
                if (var1 + var2 == i)
                {
                    if (i%2 != 0)
                    {
                        acum += i;
                    }

                    if (var1 < var2)
                    {
                        var1 = i;
                    }
                    else if (var1 >= var2)
                    {
                        var2 = i;
                    }
                }
            }
            
            Console.WriteLine(acum);

            Console.ReadLine();
        }
    }
}
