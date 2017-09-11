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
            int x, y,z,j,t;
            string c="9", s = "";

            for (int i = 0; i < b.Length; i++)
            {
                x = Convert.ToInt32(a[i]);
                y = Convert.ToInt32(b[i]);
                z =x-y;
                if (z < 0)
                {
                    j = i + 1;
                    while (Convert.ToInt32(a[j]) == 0)
                    {
                        c = a.Remove(j,1);
                        a = c.Insert(j, "0");
                        j++;
                    }
                    t= Convert.ToInt32(a[j])-1;
                    c = a.Remove(j, 1);
                    a = c.Insert(j, Convert.ToString(Convert.ToChar(t)));
                    z += 10;
                }
                s += Convert.ToString(z);
            }
            for(int i = b.Length; i < a.Length; i++)
            {
                s += Convert.ToString(a[i]);
            }
            return s;
        }

        static string Create(int f, int k)
        {
            // Образование строки-числа вида f*10^k.
            // В обратном порядке, т.к. так проще считать.
            string s = "";
            for (int i=0; i < k; i++)
            {
                s += "0";
            }
            s+= Convert.ToString(f);
            return s;
        }

        static string Reverse(string a)
        {
            // Переворот числа.
            string s = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                s += Convert.ToString(a[i]);
            }
            return s;
        }

        static void Main(string[] args)
        {
            int n;
            string a, b;
            n = int.Parse(Console.ReadLine());
            // Из формулы суммы арифметической прогресии следует, что сумма
            // всех n-значных чисел = 495*10^(2*n-3)-45*10^(n-2).
            a = Create(594, 2 * n - 3);
            b = Create(54, n - 2);
            a = Subtrac(a, b);
            a = Reverse(a);
            if (n == 1)
            {
                a = "45";
                // Костыль, ибо функция вычитания не работает корректно для n=1.
            }
            Console.WriteLine("Сумма всех {0}-значных чисел={1}", n, a);
            Console.ReadLine();
            // При больших n, число разделяет слэш - видимо не хватает размера строки.
        }
    }
}
