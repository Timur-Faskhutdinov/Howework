using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Если показывает время == 0 - значит слишком маленькое число!
            int t1, t2, t3, t4;
            LongInteger i = new LongInteger("1");
            LongInteger k = new LongInteger(Console.ReadLine());
            LongInteger n = new LongInteger("1");
            LongInteger g = new LongInteger("1");
            LongInteger j = new LongInteger("1");
            t1 = Environment.TickCount & Int32.MaxValue;
            while (k.StringComparer(k.x, i.x, true))
            {
                n = n.ComplexMultiplied(n, i); // Умножение стлобиком.
                i = k.Plus(i, new LongInteger("1"));
            }
            t2 = Environment.TickCount & Int32.MaxValue;
            Console.WriteLine("{0} \n {1} {2}", n.x, "Время умножения столбиком", t2 - t1);
            t3 = Environment.TickCount & Int32.MaxValue;
            while (k.StringComparer(k.x, j.x, true))
            {
                g = n.Karatsuba(g, j); // (n!)^2
                j = k.Plus(j, new LongInteger("1"));
            }
            t4 = Environment.TickCount & Int32.MaxValue;
            Console.WriteLine("{0} \n {1} {2}", g.x, "Время умножения Карацубой", t4 - t3);
            if((t2-t1)<(t4-t3))
                Console.WriteLine("Победили консерваторы");
            if ((t2 - t1) > (t4 - t3))
                Console.WriteLine("Победил Карацуба");
            if ((t2 - t1) == (t4 - t3))
                Console.WriteLine("Победила дружба");
            Console.ReadLine();
            // В теории, умножение Карацубы должно быть быстрее(n^log(2)3 против n^2), но не в моей строковой реализации этого.
        }
    }
}
