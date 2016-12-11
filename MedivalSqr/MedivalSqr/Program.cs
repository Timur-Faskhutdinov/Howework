using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedivalSqr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сначала кол-во точек, потом - сами точки");
            int n = int.Parse(Console.ReadLine());
            double x,y;
            double sum1 = 0.0, sumofsqr1 = 0.0, sumofsqr2 = 0.0, sqrofsum2 = 0.0;
            for (int i = 0; i < n; i++)
            {
                x=double.Parse(Console.ReadLine());
                y=double.Parse(Console.ReadLine());
                sqrofsum2 += x;
                sumofsqr2 += x * x;
                sum1 += y;
                sumofsqr1 += x * y;
            }
            x = (sumofsqr1 * n - sqrofsum2 * sum1) / (n * sumofsqr2 - sqrofsum2 * sqrofsum2);
            y = (sum1 - x * sqrofsum2);
            y /= n;
            Console.WriteLine($"y={x}x+({y})");
            Console.ReadLine();
        }
    }
}
