using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_by_dice
{
    class Game
    {
        int playervalue;
        Player[] gamers;
        //public bool newgame;
        public Game()
        {
            //Console.WriteLine("Введите количество игроков");
            playervalue = 2;// int.Parse(Console.ReadLine());
            Player[] gamers = new Player[playervalue];
            for (int k = 0; k < playervalue; k++)
                gamers[k] = new Player();
            for (int i = 0; i < 2; i++)
            {
                List<int> max = new List<int>();
                for(int k = 0; k < playervalue; k++)
                {
                    Console.WriteLine(gamers[k]);
                }
                max = Compare();
                Console.WriteLine("Лидируют:");
                for(int k = 0; k < max.Count; k++)
                {
                    Console.Write($"{gamers[i].name} ");
                }
                Perebros();
                max = Compare();
                Console.WriteLine("Победители:");
                for (int k = 0; k < max.Count; k++)
                {
                    Console.Write($"{gamers[i].name} ");
                }
            }

        }
        public List<int> Compare()
        {
            List<int> max = new List<int>();
            int mrank = 0, mvalue = 0;
            for(int i = 0; i < playervalue; i++)
            {
                //находим мах ранг, затем сравнив валю. если одинак- возвращ список из победителей.
                if (gamers[i].dice.cm.rank > mrank)
                    mrank = gamers[i].dice.cm.rank;
            }
            for (int i = 0; i < playervalue; i++)
            {
                if (gamers[i].dice.cm.rank == mrank)
                {
                    if (gamers[i].dice.cm.val > mvalue)
                    {
                        mvalue = gamers[i].dice.cm.val;
                    }
                    
                }
            }
            for(int i = 0; i < playervalue; i++)
            {
                if ((gamers[i].dice.cm.val == mvalue) && (gamers[i].dice.cm.rank == mrank))
                    max.Add(i);
            }
            return max;
        }
        private void Perebros()
        {
            Console.WriteLine("Какие кости перебрасывать?");
            for (int i = 0; i < playervalue; i++)
            {
                Console.WriteLine($"{gamers[i].name}:");
                gamers[i].Reroll(Console.ReadLine());
            }
        }
    }
}
