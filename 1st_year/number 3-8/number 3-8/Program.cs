using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            LongInteger k = new LongInteger("2");
            k = k.Minus(k.PowInteger(k, new LongInteger("11213")), new LongInteger("1"));
            Console.WriteLine(k.x);
            Console.WriteLine(k.x.Contains("99"));
            Console.ReadLine();
        }
    }
}
