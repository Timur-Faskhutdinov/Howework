using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number10
{
    class Program
    {
        static Int64 PowByMod(decimal a, decimal k, decimal n)
        {
            // Возведение в степень по модулю.
            decimal b = 1;

            while (k > 0)
            {
                if (k % 2 == 0)
                {
                    k /= 2;
                    a = (a * a) % n;
                }
                else
                {
                    k--;
                    b = (b * a) % n;
                }
            }
            return Convert.ToInt64(b);
        }

        static void Decomp(Int64 n, out int s, out Int64 t)
        {
            // Разложение n-1=2^s*t
            t = n - 1;
            s = 0;
            while (t % 2 == 0)
            {
                s++;
                t /= 2;
            }
            //Console.WriteLine("s {0}", s);
            //Console.WriteLine("t {0}", t);
            //Console.WriteLine("n {0}", n);

        }

        static bool TestMR(Int64 n)
        {
            // Тест Миллера-Рабина на простоту.
            Random rnd = new Random();
            bool f = true, exit = false;
            // Exit - вместо break и goto.
            int r, s = 0;
            Int64 a, x, t = 0;

            r = Convert.ToInt32(Math.Round(Math.Log(n) / Math.Log(2)));
            // Количество проверок.
            Decomp(n, out s, out t);
            for (int i = 0; i < r; i++)
            {
                exit = false;

                if (n > 100000000)
                {
                    a = rnd.Next(2, 100000000);
                }
                else
                {
                    if (n < 3)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = rnd.Next(2, Convert.ToInt32(n - 1));
                    }
                    
                    
                }


                x = PowByMod(a, t, n);


                if ((x != 1) && (x != n - 1))
                {
                    for (int j = 0; j < s - 1; j++)
                    {
                        if (exit == false)
                        {
                            x = PowByMod(x, 2, n);


                            if (x == 1)
                            {
                                f = false;
                            }
                            if (x == n - 1)
                            {
                                exit = true;
                            }
                        }

                    }
                    if (exit == false)
                    {
                        f = false;
                    }
                }


            }

            if (n == 2)
            {
                f = true;
            }
             
            return f;
        }

        static Int64 Nech(Int64 n)
        {

            return n;
        }

        static void Main(string[] args)
        {
            Int64 n, g;
            bool q = false;
            // False - составное, true - простое.
            n = Int64.Parse(Console.ReadLine());
            double p = n / 2;
            // q = TestMR(n);
            // if (q == true)
            // {
            // Я не проверяю само число на простоту, т.к. не могу организовать проверку для всех n без выхода
            // за границу decimal (Выход поисходит в функции PowByMod).
            //   g = n;
            // }
            // else
            // {
            g = Convert.ToInt64(Math.Round(p)) + 1;
            while ((g >= 2) && (q == false))
            {
                g--;
                if ((n % g == 0) &&((g%2!=0) ||(g==2)))
                {
                    q = TestMR(g);
                }
            }
            // }
            if (q == false)
            {
                g = 1;
            }
            Console.WriteLine("Самый большой простой делитель {0}",g);
            Console.ReadLine();


        }
    }
}
