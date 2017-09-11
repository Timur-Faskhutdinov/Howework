using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, n;
            double s;
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            a2 = a2 - a1;
            // Вычисляю разность прогрессии, а дальше использую стандартную формулу.
            s = (2 * a1 + (n - 1) * a2) * n / 2;
            Console.WriteLine("Сумма = {0}",s);
        }
    }
}
