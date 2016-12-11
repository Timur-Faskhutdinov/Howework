using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_by_dice
{

    class Program
    {
        static void Main(string[] args)
        {
            bool newgame = true;
            while (newgame)
            {
                Game a = new Game();
                Console.WriteLine("Хотите начать новую игру(true/false):");
                newgame = bool.Parse(Console.ReadLine());
            }
        }
    }
}
