using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex emr = new Regex(File.ReadAllText("input.txt"));
            bool f = true;
            while (f)
            {
                string tes1 = Console.ReadLine();
                if (emr.IsMatch(tes1))
                {
                    Console.WriteLine("Right");
                }
                else
                {

                    Console.WriteLine("Wrong");
                }
            }
        }
    }
}
