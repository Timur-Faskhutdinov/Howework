using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сначала х, потом точность:");
            double x;
            int k = 1;
            x = double.Parse(Console.ReadLine());
            double e, s1, s2, powfact = (x * x)/2, z = x * x;
            bool f = false;
            e = double.Parse(Console.ReadLine());
            s1 = 1;
            while (f == false)
            {
                s2 = s1;
                s1 += powfact;
                k++;
                powfact *= (z / (2 * k * (2*k - 1)));
                if (Math.Abs(s1 - s2) <= e)
                {
                    f = true;
                }
            }
            Console.WriteLine("Шаг {0}\nСумма {1}", k, s1);
            Console.ReadLine();

        }
    }
}
