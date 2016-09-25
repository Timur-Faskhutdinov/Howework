using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number9
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 a;
            double k=0, maxk=0;
            a = Int64.Parse(Console.ReadLine());
            if (a == 0)
            {
                maxk = 1;
            } 
            // Если был введен один лишь ноль.
            while (a != 0)
            {
                if (a % 2 == 0)
                {
                    k++;
                }
                else
                {
                    if (k > maxk)
                    {
                        maxk = k;
                    }
                    k = 0;
                }
                a = Int64.Parse(Console.ReadLine());
                if ((a==0) && (k == maxk))
                {
                    maxk++;
                }
                // Поскольку 0 является чётным чисом, я учитываю его, если это повлияет на мах длинну.
                // (В т.ч. когда 0 - единственное введёное чётное число).
            }
            Console.WriteLine("Самая длинная последовательность чётных чисел - {0}", maxk);
        }
    }
}
