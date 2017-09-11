using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LongInteger k = new LongInteger(Console.ReadLine());
            LongInteger s = new LongInteger("1");
            LongInteger n = new LongInteger("1");
            LongInteger i = new LongInteger("2");
            while (k.StringComparer(k.x, i.x, true))
            {
                n = n.ComplexMultiplied(n, n.PowInteger(i, new LongInteger("2"))); // (n!)^2
                s = s.Plus(s, n);
                i = k.Plus(i, new LongInteger("1"));
            }
            Console.WriteLine(s.x);
            Console.ReadLine();
        }
    }
}
