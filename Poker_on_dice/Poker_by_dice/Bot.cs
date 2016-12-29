using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Poker_by_dice
{
    class Bot : Player
    {
        public Bot(int k)
        {
            name = $"Bot_{k+1}";
            dice.Roll();
        }
        public new void Reroll(string a)
        {
            Thread.Sleep(50);
            dice.Roll(dice.Cm.freedices);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
