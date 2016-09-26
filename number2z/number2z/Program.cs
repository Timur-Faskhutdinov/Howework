using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3, b1, b2, b3, x, y, r1, r2, r3;
            // ai - абсцисса точки i, bi - ордината, ri - расстояние до искомой точки. 
                a1 = double.Parse(Console.ReadLine());
                b1 = double.Parse(Console.ReadLine());
                a2 = double.Parse(Console.ReadLine());
                b2 = double.Parse(Console.ReadLine());
                a3 = double.Parse(Console.ReadLine());
                b3 = double.Parse(Console.ReadLine());
                r1 = double.Parse(Console.ReadLine());
                r2 = double.Parse(Console.ReadLine());
                r3 = double.Parse(Console.ReadLine());
            //a1 = 1; b1 = 1; a2 = 1; b2 = 6; a3 = 4; b3 = 1; r1 = Math.Sqrt(200); r2 = Math.Sqrt(125); r3 = Math.Sqrt(149); //(11,11)
            //a1 = 2; b1 = 2; a2 = 4; b2 = 5; a3 = 6; b3 = 3; r1 = Math.Sqrt(50); r2 = Math.Sqrt(13); r3 = Math.Sqrt(17); //(7,7)
            // (Проверочные значения).

            x = (0.5) * (a1 * a1 * b2 - a1 * a1 * b3 - a2 * a2 * b1 + a2 * a2 * b3 + a3 * a3 * b1 - a3 * a3 * b2 + b1 * b1 * b2 - b1 * b1 * b3 - b1 * b2 * b2 + b1 * b3 * b3 + b1 * r2 * r2 - b1 * r3 * r3 + b2 * b2 * b3 - b2 * b3 * b3 - b2 * r1 * r1 + b2 * r3 * r3 + b3 * r1 * r1 - b3 * r2 * r2) / (a1 * b2 - a1 * b3 - a2 * b1 + a2 * b3 + a3 * b1 - a3 * b2);
            y = -(0.5) * (a1 * a1 * a2 - a1 * a1 * a3 - a1 * a2 * a2 + a1 * a3 * a3 - a1 * b2 * b2 + a1 * b3 * b3 + a1 * r2 * r2 - a1 * r3 * r3 + a2 * a2 * a3 - a2 * a3 * a3 + a2 * b1 * b1 - a2 * b3 * b3 - a2 * r1 * r1 + a2 * r3 * r3 - a3 * b1 * b1 + a3 * b2 * b2 + a3 * r1 * r1 - a3 * r2 * r2) / (a1 * b2 - a1 * b3 - a2 * b1 + a2 * b3 + a3 * b1 - a3 * b2);
            // Решал через систему уравнений, каждое из которых задавало окружность. Её решение - искосая точка.
            // Формулы вывела программа Maple.
            Console.WriteLine("x {0}",x);
            Console.WriteLine("y {0}",y);
            Console.ReadLine();
           
        }
    }
}
