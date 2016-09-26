using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 n, i;
            double s = 1;
            n = Int64.Parse(Console.ReadLine());
            for (i = 2; i < n; i++)
            {
                s += i;
            }
            Console.WriteLine("Сумма = {0}",s);
        }
    }
}
