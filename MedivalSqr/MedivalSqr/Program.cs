using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedivalSqr
{
    class Decartcoord
    {
        public double x;
        public double y;
        public Decartcoord(double x,double y)
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
            double x,y,r;
            double sum1 = 0.0, sumofsqr1 = 0.0, sumofsqr2 = 0.0, sqrofsum2 = 0.0;
            for (int i = 0; i < n; i++)
            {
                lst.Add(new Decartcoord(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                Console.WriteLine();
                sqrofsum2 += lst[i].x;
                sumofsqr2 += lst[i].x * lst[i].x;
                sum1 += lst[i].y;
                sumofsqr1 += lst[i].x * lst[i].y;
            }
            x = (double)(sumofsqr1 * n - sqrofsum2 * sum1) / (n * sumofsqr2 - sqrofsum2 * sqrofsum2);
            y = (double)(sum1 - x * sqrofsum2) / n;
            Console.WriteLine($"y={x}x+({y})");
            sum1 = (double)sum1 / n;
            sumofsqr1 = 0.0;
            sumofsqr2 = 0.0;
            sqrofsum2 = 0.0;
            for(int i = 0; i < n; i++)
            {
                sumofsqr1 += (lst[i].y - sum1) * (lst[i].y - sum1);
                sumofsqr2 += (lst[i].y - (x * lst[i].x + y)) * (lst[i].y - (x * lst[i].x + y));
            }
            r = Math.Sqrt(1 - sumofsqr2 / sumofsqr1);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
