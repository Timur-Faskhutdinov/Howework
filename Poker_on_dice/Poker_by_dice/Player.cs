﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_by_dice
{
    class Player
    {
        public class cmbt
        {
            public int val;
            public int rank;
            public string name;
        }
        public class Combination
        {
            int[] dices = new int[5];
            private cmbt cm = new cmbt();
            public Combination() { }
            public cmbt Cm
            {
                get
                {
                    int k1 = 0, m1 = 0, k2 = 0, m2 = -1;
                    for (int i = 1; i <= 6; i++)
                    {
                        int k = 0;
                        for (int j = 0; j < dices.Length; j++)
                        {
                            if (dices[j] == i)
                            {
                                k++;
                            }
                        }

                        if (k >= k2)
                        {
                            if (k >= k1)
                            {
                                //k1-колво повторов кубов, m1 - их ранг, k2 m2 для фуллхауса.
                                m2 = m1;
                                k2 = k1;
                                m1 = i;
                                k1 = k;
                            }
                            else
                            {
                                m2 = i;
                                k2 = k;
                            }
                        }
                    }
                    switch (k1)
                    {
                        case 1:
                            cm.name = "нет комбинации";
                            cm.rank = 0;
                            cm.val = m1;
                            break;
                        case 2:
                            if (k2 == 2)
                            {
                                cm.name = "две пары";
                                cm.rank = 2;
                                cm.val = m1 + m2;
                            }
                            else
                            {
                                cm.name = "пара";
                                cm.rank = 1;
                                cm.val = m1;
                            }
                            break;
                        case 3:
                            if (k2 == 2)
                            {
                                cm.name = "фуллхаус";
                                cm.rank = 4;
                                cm.val = 3 * m1 + 2 * m2;
                            }
                            else
                            {
                                cm.name = "тройка";
                                cm.rank = 3;
                                cm.val = m1;
                            }
                            break;
                        case 4:
                            cm.name = "каре";
                            cm.rank = 5;
                            cm.val = m1;
                            break;
                        case 5:
                            cm.name = "покер";
                            cm.rank = 6;
                            cm.val = m1;
                            break;
                        default:
                            break;
                    }
                    return cm;
                }
            }
            public void Roll(string s = "12345")
            {
                Random r = new Random();
                for (int i = 0; i < s.Length; i++)
                {
                    dices[Convert.ToInt32(Convert.ToString(s[i])) - 1] = r.Next(1, 7);
                }
            }
            public override string ToString()
            {
                StringBuilder s = new StringBuilder("|");
                for (int i=0;i<5;i++)
                {
                    s.Append(Convert.ToString(dices[i]));
                    s.Append("|");
                }
                return s.ToString();
            }
        }
            public string name { get; private set; }
        public Combination dice = new Combination();
        public Player()
        {
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            dice.Roll();
        }
        public void Reroll(string a)
        {
            dice.Roll(a);
        }
        public override string ToString()
        {
            return string.Format($"{name}\n {dice}\n {dice.Cm.name}"); //power: { dice.Cm.val}
        }
    }
}
