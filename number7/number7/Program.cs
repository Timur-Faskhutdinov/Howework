using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number7
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 a;
            double k, s=0;
            a = Int64.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a % 2 == 0)
                {
                    // Проверяю действительно ли число - степень двойки и считаю саму степень.
                    k = 0;
                    while((a > 1) && (a % 2 == 0))
                    {
                        a /= 2;
                        k++;
                    }
                    if (a == 1)
                    {
                        s += k;
                    }
                }
                a = Int64.Parse(Console.ReadLine());
            }
            // Может, я не правильно понял, что надо вывести. Программа выведет именно сумму
            // степеней, то есть если ввести 2^k, 2^n, то программа выведет s=k+n
            Console.WriteLine("Сумма {0}", s);
        }
    }
}
