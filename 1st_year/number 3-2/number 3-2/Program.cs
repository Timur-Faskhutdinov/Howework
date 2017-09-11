using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сначала мантиса в виде #_.______# потом - целый порядок");
            LongDecimal a = new LongDecimal(Console.ReadLine(), int.Parse(Console.ReadLine()));
            LongDecimal b = new LongDecimal(Console.ReadLine(), int.Parse(Console.ReadLine()));
            a.Print(a.DoublePow(a, b, 35));
            Console.ReadLine();
        }
    }
}
