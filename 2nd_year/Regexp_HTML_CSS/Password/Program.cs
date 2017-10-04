using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r1 = new Regex(@"^[A-Za-z](?:[A-Za-z0-9]|_|%|~|\?|\<|\>|\$){7,}$");
            //(?>[a-z])(?>[A-Z])(?>[0-9])
            Regex r2 = new Regex(@"[a-z]");
            Regex r3 = new Regex(@"[A-Z]");
            Regex r4 = new Regex(@"[0-9]");
            bool f = true;
            while (f)
            {
                string tes1 = Console.ReadLine();
                if ((r1.IsMatch(tes1))&&(r2.IsMatch(tes1))&&(r3.IsMatch(tes1))&&(r4.IsMatch(tes1)))
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
