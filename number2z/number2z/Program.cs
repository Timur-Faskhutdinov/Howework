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
            double a1, a2, a3, b1, b2, b3, c, D, x, y,x1,y1, x2, y2, r1, r2, r3, n, m;
            // ai - абсцисса точки i, bi - ордината, ri - расстояние до искомой точки. 
            // D - дискриминант. xi, yi - точка пересечения двух окружностей.
            // n, m, c - промежуточные значения.

            if (1 == 0)

            {

                n = a1 - a2;
                m = b1 - b2;
                c = r2 * r2 - r1 * r1 - n * n - m * m;
                D = Math.Sqrt(c * c * m * m - (c * c - r1 * r1 * 4 * n * n) * (m * m + n * n));
                y1 = 4 * c * m - D;
                y2 = 4 * c * m + D;
                x1 = (c - 2 * m * y1) / (2 * n);
                x2 = (c - 2 * m * y2) / (2 * n);
                y1 -= b1;
                y2 -= b2;
                x1 -= a1;
                x2 -= a2;
                if ((x2 - a3) * (x2 - a3) + (y2 - b3) * (y2 - b3) == r3 * r3)
                {
                    x1 = x2;
                    y1 = y2;
                }

                //TODO ввод координат точек, расстояний до иходной.




                n = (a2 - a1);
                m = (b2 - b1);
                c = -(r2 * r2 - r1 * r1 - n * n - m * m) / 2;

                if (n == 0)
                {
                    y1 = c / m;
                    y2 = y1;
                    x1 = Math.Sqrt(r1 * r1 - y1 * y1);
                    x2 = -x1;
                }
                else if (m == 0)
                {
                    x1 = c / n;
                    x2 = x1;
                    y1 = Math.Sqrt(r1 * r1 - x1 * x1);
                    y2 = -y1;
                }
                else
                {
                    D = 2 * Math.Sqrt(c * c * m * m - (n * n + m * m) * (c * c - r1 * r1 * n * n));
                    y1 = (2 * c * m + D) / (2 * (m * m + n * n));
                    y2 = (2 * c * m - D) / (2 * (m * m + n * n));
                    x1 = Math.Sqrt(r1 * r1 - y1 * y1);
                    x2 = Math.Sqrt(r1 * r1 - y2 * y2);
                }

                y1 += b1;
                y2 += b1;
                x1 += a1;
                x2 += a1;

                if (Math.Abs((x2 - a3) * (x2 - a3) + (y2 - b3) * (y2 - b3)) - (r3 * r3) < Math.Abs((x1 - a3) * (x1 - a3) + (y1 - b3) * (y1 - b3)) - (r3 * r3))
                {
                    x1 = x2;
                    y1 = y2;
                }
                Console.WriteLine("Координаты искомой точки ({0} ; {1})", x1, y1); //МАССИВ!
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", m, c, 2 * Math.Sqrt(c * c * m * m - (n * n + m * m) * (c * c - r1 * r1 * n * n)), x1, x2, y1);
                Console.ReadLine();
                //Работает не для всех значений.
                // идея - сделать точки пересеч. 1ого и 3его уравн. те что совпадают- вывести.




                a1 = double.Parse(Console.ReadLine());
                b1 = double.Parse(Console.ReadLine());
                a2 = double.Parse(Console.ReadLine());
                b2 = double.Parse(Console.ReadLine());
                a3 = double.Parse(Console.ReadLine());
                b3 = double.Parse(Console.ReadLine());
                r1 = double.Parse(Console.ReadLine());
                r2 = double.Parse(Console.ReadLine());
                r3 = double.Parse(Console.ReadLine());

            }


            //a1 = 1; b1 = 1; a2 = 1; b2 = 6; a3 = 4; b3 = 1; r1 = Math.Sqrt(200); r2 = Math.Sqrt(125); r3 = Math.Sqrt(149);
            a1 = 2; b1 = 2; a2 = 4; b2 = 5; a3 = 6; b3 = 3; r1 = Math.Sqrt(50); r2 = Math.Sqrt(13); r3 = Math.Sqrt(17);

            //TODO расчет координат искомой точки.
            
            if (a2 == a1)
            {
                y = (r1 * r1 - r3 * r3) / (2 * (b2 - b1));
                x = (r1 * r1 - r3 * r3 + 2 * (b1 - b3) * y) / (2 * (a3 - a1));
            }
            else
            {
                y = ((r1 * r1 - r3 * r3) * (a2 - a1) + (a1 - a3) * (r1 * r1 - r2 * r2)) / (2 * ((a3 - a1) * (b1 - b2) + (b3 - b1) * (a2 - a1)));
                x = (r1 * r1 - r2 * r2 + 2 * (b1 - b2) * y) / (2 * (a2 - a1));
            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
           
        }
    }
}
