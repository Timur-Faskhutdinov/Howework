using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=1;
            double s1,s2=0, e,x;
            Console.WriteLine("Сначала х, потом точность:");
            x = double.Parse(Console.ReadLine());
            e = double.Parse(Console.ReadLine());
            double pow = x, log = Math.Log(3), z = log*x;
            s1 = 1;
            bool f = false;
            while (f == false)
            {
                s2 = s1;
                s1 += z;

                //Console.WriteLine(Math.Abs(s1 - s2));
                //Console.WriteLine(z);

                k++;
                z *= (pow * log / k);
                //pow *= x;
                //log *= z;
                //fact *= k;
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
