using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedivalSqr
{
    class Decartcoord
    {
        public decimal x;
        public decimal y;
        public Decartcoord(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сначала кол-во точек, потом - сами точки");
            List<Decartcoord> lst = new List<Decartcoord>();
            int n = int.Parse(Console.ReadLine());
            decimal x, y;
            double r;
            decimal sum1 = 0.0M, sumofsqr1 = 0.0M, sumofsqr2 = 0.0M, sqrofsum2 = 0.0M;
            for (int i = 0; i < n; i++)
            {
                lst.Add(new Decartcoord(decimal.Parse(Console.ReadLine()), decimal.Parse(Console.ReadLine())));
                Console.WriteLine();
                sqrofsum2 += lst[i].x;
                sumofsqr2 += lst[i].x * lst[i].x;
                sum1 += lst[i].y;
                sumofsqr1 += lst[i].x * lst[i].y;
            }
            x = (decimal)(sumofsqr1 * n - sqrofsum2 * sum1) / (n * sumofsqr2 - sqrofsum2 * sqrofsum2);
            y = (decimal)(sum1 - x * sqrofsum2) / n;
            Console.WriteLine($"y={x}x+({y})");
            sum1 = (decimal)sum1 / n;
            sumofsqr1 = 0.0M;
            sumofsqr2 = 0.0M;
            sqrofsum2 = 0.0M;
            for(int i = 0; i < n; i++)
            {
                sumofsqr1 += (lst[i].y - sum1) * (lst[i].y - sum1);
                sumofsqr2 += (lst[i].y - (x * lst[i].x + y)) * (lst[i].y - (x * lst[i].x + y));
            }
            r = Math.Sqrt(Convert.ToDouble(1 - sumofsqr2 / sumofsqr1));
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
