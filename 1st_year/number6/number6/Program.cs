using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number6
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double ak, an, s, d;
            ak = double.Parse(Console.ReadLine());
            an = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            r = Convert.ToInt32((an - ak) / d - 1);
            s = (2 * ak + (r + 1) * d) * r / 2;
            Console.WriteLine("Кол-во элементов {0}, их сумма {1}", r, s);
        }
    }
}
