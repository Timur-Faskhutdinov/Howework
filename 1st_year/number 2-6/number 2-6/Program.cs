using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_6
{
    class Program
    {
        static double f(double x)
        {
            double s;
            s = Math.Sin(x);
            s = Math.Cos(s);
            return s;
        }

        static void Main(string[] args)
        {
            double a = 1, b = 3, n = 100000, h, s = 0;
            h = (b - a) / n;
            for(int i=0; i<n; i++)
            {
                b = a + (i + 1) * h;
                s += f(b);
            }
            s *= h;
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
