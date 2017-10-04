using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05b
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"(^|(1|3|5|7|9))(0|2|4|6|8){2}((1|3|5|7|9)([0-9](1|3|5|7|9))*)(0|2|4|6|8){2}($|(1|3|5|7|9))");
            int k = 0;
            int i = 0;
            string temp;
            Random rnd = new Random();
            while (i < 10)
            {
                k++;
                temp = rnd.Next(1000001).ToString();
                //if (r.IsMatch(temp) & (r1.IsMatch(temp)))
                if (r.IsMatch(temp))
                {
                    Console.Write($"{temp} ");
                    i++;
                }
            }

            Console.Write($"\n{k}");
            Console.ReadLine();
        }
    }
}
