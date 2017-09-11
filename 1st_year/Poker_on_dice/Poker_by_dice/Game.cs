using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_by_dice
{
    class Game
    {
        int playervalue,botvalue;
        List<Player> gamers = new List<Player>();
        public Game()
        {
            Console.WriteLine("Введите количество игроков:");
            playervalue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество ботов");
            botvalue = int.Parse(Console.ReadLine());
            for (int k = 0; k < playervalue; k++)
                gamers.Add(new Player(k));
            for (int k = 0; k < botvalue; k++)
                gamers.Add(new Bot(k));
            List<int> max = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                max.Clear();
                for(int k = 0; k < playervalue+botvalue; k++)
                {
                    Console.WriteLine(gamers[k]);
                }
                max = Compare();
                Console.WriteLine("\nЛидируют:");
                for(int k = 0; k < max.Count; k++)
                {
                    Console.Write($"{gamers[max[k]].name} ");
                }
                Perebros();              
            }
            for (int k = 0; k < playervalue + botvalue; k++)
            {
                Console.WriteLine(gamers[k]);
            }
            max = Compare();
            Console.WriteLine("\nПобедители:");
            for (int k = 0; k < max.Count; k++)
            {
                Console.Write($"{gamers[max[k]].name} ");
            }
            Console.WriteLine();
        }
        public List<int> Compare()
        {
            List<int> max = new List<int>();
            int mrank = 0, mvalue = 0;
            for(int i = 0; i < playervalue + botvalue; i++)
            {
                //находим мах ранг, затем сравнив валю. если одинак- возвращ список из победителей.
                if (gamers[i].dice.Cm.rank > mrank)
                    mrank = gamers[i].dice.Cm.rank;
            }
            for (int i = 0; i < playervalue + botvalue; i++)
            {
                if (gamers[i].dice.Cm.rank == mrank)
                {
                    if (gamers[i].dice.Cm.val > mvalue)
                    {
                        mvalue = gamers[i].dice.Cm.val;
                    }
                    
                }
            }
            for(int i = 0; i < playervalue + botvalue; i++)
            {
                if ((gamers[i].dice.Cm.val == mvalue) && (gamers[i].dice.Cm.rank == mrank))
                    max.Add(i);
            }
            return max;
        }
        private void Perebros()
        {
            Console.WriteLine("\nКакие кости перебрасывать?");
            for (int i = 0; i < playervalue; i++)
            {
                Console.WriteLine($"{gamers[i].name}:");
                gamers[i].Reroll(Console.ReadLine());
            }
            for (int i = playervalue; i < playervalue + botvalue; i++)
            {
                gamers[i].Reroll(gamers[i].dice.Cm.freedices);
            }
        }
    }
}
