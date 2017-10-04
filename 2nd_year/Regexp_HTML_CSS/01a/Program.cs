using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01a
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"^(?:-|\+)?\d+(?:(?:,|\.)\d*(?:\(\d+\))?)?$");

            bool f = true;

            while (f)
            {
                string tes1 = Console.ReadLine();
                if (r.IsMatch(tes1))
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
