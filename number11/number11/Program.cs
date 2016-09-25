using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number11
{
    class Program
    {
        static string Subtrac(string a, string b)
        {
            // Вычитание длинной арифметики.
            string s="";
            return s;
        }

        static string Create(int f, int k)
        {
            // Образование строки-числа вида f*10^k.
            string s = "";
            return s;
        }

        static void Main(string[] args)
        {
            int n;
            string a, b;
            n = int.Parse(Console.ReadLine());
            a = Create(495, 2 * n - 3);
            b = Create(45, n - 2);
            a = Subtrac(a, b);
            Console.WriteLine("Сумма всех {0}-значных чисел={1}", n, a);
        }
    }
}
