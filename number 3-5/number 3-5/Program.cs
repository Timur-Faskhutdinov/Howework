using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            LongInteger k = new LongInteger(Console.ReadLine());
            LongInteger n = new LongInteger(Console.ReadLine());
            LongInteger s = new LongInteger("0");
            s = s.Minus(s.PowInteger(k, n), new LongInteger("1")); // k^(n)-1. Возведение в степень - быстрое, если что.
            k = s.Minus(k, new LongInteger("1")); // k-1.
            s = s.Divided(s, k); // s/k.
            Console.WriteLine(s.x);           
            Console.ReadLine();
        }
    }
}
