using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Poker_by_dice
{

    class Program
    {
        static void Main(string[] args)
        {
            bool newgame = true;
            Console.WriteLine("ПОКЕР НА КОСТЯХ v2.0\nПатчноут: в версии 2.0 добавлены боты");
            while (newgame)
            {
                Game a = new Game();
                Console.WriteLine("Хотите начать новую игру(true/false):");
                newgame = bool.TryParse(Console.ReadLine(),out newgame);
            }
        }
    }
}
