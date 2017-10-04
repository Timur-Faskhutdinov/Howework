using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03b
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //Regex r = new Regex(@"(?:0|2|4|6|8)$");
            Regex r1 = new Regex(@"^(?:0|2|4|6|8){0,2}(?:(?:1|3|5|7|9)+(?:0|2|4|6|8){0,2})*$");
            int k = 0;
            int i = 0;
            string temp;
            while (i < 10)
            {
                k++;
                temp = rnd.Next(1000001).ToString();
                //if (r.IsMatch(temp) & (r1.IsMatch(temp)))
                if (r1.IsMatch(temp))
                {
                    Console.Write($"{temp} ");
                    i++;
                }
            }
            //bool f = true;
            //while (f)
            //{
            //    string tes1 = Console.ReadLine();
            //    if (r1.IsMatch(tes1))
            //    {
            //        Console.WriteLine("Right");
            //    }
            //    else
            //    {

            //        Console.WriteLine("Wrong");
            //    }
            //}
            Console.ReadLine();
            Console.Write($"\n{k}");
            //Console.WriteLine(r1.IsMatch("1442"));
            Console.ReadLine();
        }
    }
}
