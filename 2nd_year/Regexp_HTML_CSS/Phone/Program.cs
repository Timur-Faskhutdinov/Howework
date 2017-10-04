using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"^(?:(\+\d)|\d)(?: |-|\()?\d{3}(?: |-|\))?\d{3}(?: |-)?\d{2}(?: |-)?\d{2}$");
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
