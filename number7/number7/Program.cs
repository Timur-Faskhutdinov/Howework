using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number7
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 a;
            double k, s=0;
            a = Int64.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a % 2 == 0)
                {
                    k = 0;
                    while((a > 1) && (a % 2 == 0))
                    {
                        a /= 2;
                        k++;
                    }
                    if (a == 1)
                    {
                        s += k;
                    }
                }
                a = Int64.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма {0}", s);
        }
    }
}
