using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18_part1
{
    class Program
    {

        static void Main(string[] args)
        {
            int a, b, i=0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            // Сравниваются пары, начиная с низшей по разряду.
            for(int k=1; k < 4; k++)
            {
                if ((a % 10) == (b % 10))
                {
                    i++;
                }
                a = a / 10;
                b = b / 10;
            }
            Console.WriteLine(i);
        }
    }
}
