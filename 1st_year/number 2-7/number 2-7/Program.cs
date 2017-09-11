using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_7
{
    class Program
    {
        static double f(double x)
        {
            double s;
            s = 1 / x + x * x / 4;
            s = Math.Cos(s);
            return s;
        }

        static void Main(string[] args)
        {
            double a = 0.5, b = 2, n = 100000, h, s, sAver = 0; ;
            h = (b - a) / n;
            Random r = new Random();
            for(int y=0;y<5; y++)
                // Прогоняю 5 раз для уменьшения ошибки.
            {
                s = 0;
                for (int i = 0; i < n; i++)
                {
                    b = a + r.Next(Convert.ToInt32(n)) * h;
                    s += f(b);
                }
                sAver+=s;
            }
            s = sAver * h / 5;
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
