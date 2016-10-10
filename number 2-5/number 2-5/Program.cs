using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,e;
            x = double.Parse(Console.ReadLine());
            //e = double.Parse(Console.ReadLine());
            double a0=x, b0=1, y0=0, ak=0, bk=0, yk=0,k=1;
            bool f = false;
            //while (f == false)
            for(int i=0;i<5;i++)
            {
                ak = a0 * a0;
                bk = b0 / 2;
                if (ak < 2)
                {
                    yk = y0;
                }
                else
                {
                    yk = y0 + b0;
                }
                a0 = ak;
                b0 = bk;
                y0 = yk;
            }
            //x = Math.Pow(ak, bk) / yk;
            Console.WriteLine("a {0}\nb {1}\ny {2}", ak, bk, yk);
            //Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
