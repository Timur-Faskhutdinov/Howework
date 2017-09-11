using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int b, x;
            a = Console.ReadLine();
            b = int.Parse(Console.ReadLine());
            x = Convert.ToInt32(Convert.ToString(a[a.Length - 1]));
            int y = x;
            // Все просто - я беру последнюю цифру от а, умножаю на саму себя, из умножения получаю новую последнюю цифру,
            // опять умножаю её на последнюю цифру а и т.д.
            for (int i = 2; i <= b; i++)
            {
                y = y * x;
                y = y % 10;
            }
            Console.WriteLine("Последняя цифра {0}",y);
            Console.ReadLine();
        }
    }
}
