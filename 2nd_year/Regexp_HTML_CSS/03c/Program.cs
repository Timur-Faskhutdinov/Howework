using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03c
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Regex r = new Regex(@"(?:0|2|4|6|8)$");
            int k = 0;
            int i = 0;
            string temp;
            while (i < 10)
            {
                k++;
                temp = rnd.Next(1000001).ToString();
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
