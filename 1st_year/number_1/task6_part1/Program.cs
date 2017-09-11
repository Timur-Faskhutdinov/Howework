using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year,i;
            string s,sy;
            sy=Console.ReadLine();
            year=int.Parse(sy);
            if ((year % 400==0) ||((year % 4==0) &&(year % 100 != 0)))
            {
                s = "12";
            }
            else
            {
                s = "13";
            }
            s += "/09/";
            i = 4 - sy.Length;
            while (i > 0)
            {
                s += "0";
                i--;
            }
            s += sy;
            Console.WriteLine(s);
            }
        }
    }
