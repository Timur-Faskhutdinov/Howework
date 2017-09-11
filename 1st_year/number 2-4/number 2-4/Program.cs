using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt64 k = 1;
            double e, p1 = 2, p2,d;
            Console.WriteLine("Введите точность:");
            e = double.Parse(Console.ReadLine());
            bool f = false;
            while (f == false)
            {
                p2 = p1;
                d = (4 * k * k - 1);
                p1 *= (1 + 1 / d);
                k++;
                if (Math.PI-p1<=e/10)
                // Я пробовал сравнивать разность р1 и р2 с е, но для получения правильной точности
                // приходилось каждый раз, для разных значений е, модифицировать е в условии.
                // В итоге я так и не смог подобрать универсального: находится е, для 
                // которого, к примеру, условие е*0,01 недостаточно, а е^3 избыточно и.т.д.
                {
                    f = true;
                }
            }
            Console.WriteLine("Шаг {0}\nСумма {1}", k, p1);
            Console.ReadLine();
        }
    }
}
