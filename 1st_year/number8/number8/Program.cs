using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number8
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 a;
            a = Int64.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a > 0)
                {
                    for (Int64 k = 1; k <= a; k++)
                    {
                        Console.Write("+");
                    }
                    Console.WriteLine("|");
                    // Я посчитал, что | и переход на новую строку - сойдет за разделитель.
                }
                
                a = Int64.Parse(Console.ReadLine());
            }
        }
    }
}
