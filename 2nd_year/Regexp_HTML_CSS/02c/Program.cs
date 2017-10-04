using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = {"00","11","01010","101","1100","101001" };

            Regex r = new Regex(@"^(?:(?:^0+$|^1+$)|1?(?:01)+0?)$");
            //Regex w = new Regex(@"(?:^0+$|^1+$)");
            int k = 0;
            Console.WriteLine("True code are ");
            foreach(var i in test)
            {
                k++;
                if (r.IsMatch(i))
                {
                    Console.Write($"{k} ");
                }
            }
            Console.ReadLine();
        }
    }
}
