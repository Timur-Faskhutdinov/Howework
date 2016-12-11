using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_by_dice
{
    //class cmbt
    //{
    //    public int val;
    //    public int rank;
    //    public string name;
    //    public cmbt() { }
    //}
    //class Combination
    //{
    //    int[] dices = new int[5];
    //    private int comba;
    //    public Combination(){ }
    //    public cmbt cm
    //    {
    //        get
    //        {
    //            int k1 = 0, m1 = 0, k2 = 0, m2 = 0;
    //            for (int i = 1; i <= 6; i++)
    //            {
    //                int k = 0;
    //                for (int j = 0; j < 5; j++)
    //                {
    //                    if (dices[j] == i)
    //                    {
    //                        k++;
    //                    }
    //                }
    //                if (k >= m1)
    //                {
    //                    if (k >= m2)
    //                    {
    //                        //k1-колво повторов кубов, m1 - их ранг, k2 m2 для фуллхауса.
    //                        m2 = m1;
    //                        k2 = k1;
    //                        m1 = i;
    //                        k1 = k;
    //                    }
    //                    //else
    //                    //{
    //                    //    m1 = i;
    //                    //    k1 = k;
    //                    //}
    //                }
    //                else if (k >= m2)
    //                {
    //                    //k1-колво повторов кубов, m1 - их ранг, k2 m2 для фуллхауса.
    //                    m2 = i;
    //                    k2 = k;
    //                }
    //            }
    //            switch (k1)
    //            {
    //                case 1:
    //                    cm.name = "нет комбинации";
    //                    cm.rank = 0;
    //                    cm.val = m1;
    //                    return cm;
    //                case 2:
    //                    if (k2 == 2)
    //                    {
    //                        cm.name = "две пары";
    //                        cm.rank = 2;
    //                        cm.val = m1 + m2;
    //                    }
    //                    else
    //                    {
    //                        cm.name = "пара";
    //                        cm.rank = 1;
    //                        cm.val = m1;
    //                    }
    //                    return cm;
    //                case 3:
    //                    if (k2 == 2)
    //                    {
    //                        cm.name = "фуллхаус";
    //                        cm.rank = 4;
    //                        cm.val = 3*m1 + 2*m2;
    //                    }
    //                    else
    //                    {
    //                        cm.name = "тройка";
    //                        cm.rank = 3;
    //                        cm.val = m1;
    //                    }
    //                    return cm;
    //                case 4:
    //                    cm.name = "каре";
    //                    cm.rank = 5;
    //                    cm.val = m1;
    //                    return cm;
    //                case 5:
    //                    cm.name = "покер";
    //                    cm.rank = 6;
    //                    cm.val = m1;
    //                    return cm;
    //            }
    //            return cm;
    //        }
    //    }
    //    public void Roll(string s = "12345")
    //    {
    //        Random r = new Random();
    //        for(int i = 0; i < s.Length; i++)
    //        {
    //            dices[Convert.ToInt32(Convert.ToString(s[i]))-1] = r.Next(1, 7);
    //        }
    //    }
        // value1 + value 2 (или особые правила для фулхауса)
        //public int Comba
        //{
        //    get
        //    {
        //        int k = 0;
        //        // check comb
        //        return comba;
        //    }
        //}
        //private bool pocker()
        //{
        //    for(int i = 1; i < 5; i++)
        //    {
        //        if (dices[i] != dices[0])
        //            return false;
        //    }
        //    return true;
        //}
        //private int Check()
        //{
        //    int k1 = 0, m1 = 0,k2 = 0,m2 = 0;
        //    for(int i = 1; i <= 6; i++)
        //    {
        //        int k = 0;
        //        for(int j = 0; j < 5; j++)
        //        {
        //            if (dices[j] == i)
        //            {
        //                k++;
        //            }
        //        }
        //        if (k >= m1)
        //        {
        //            if (k >= m2)
        //            {
        //                //k1-колво повторов кубов, m1 - их ранг, k2 m2 для фуллхауса.
        //                m2 = m1;
        //                k2 = k1;
        //                m1 = i;
        //                k1 = k;
        //            }
        //            else
        //            {
        //                m1 = i;
        //                k1 = k;
        //            }
        //        }
        //        else if (k >= m2)
        //        {
        //            //k1-колво повторов кубов, m1 - их ранг, k2 m2 для фуллхауса.
        //            m2 = i;
        //            k2 = k;
        //        }
        //            //Покер — пять костей одного вида
        //            //Каре — четыре кости одного вида
        //            //Фулл хаус — три кости одного вида +пара
        //            //Тройка — три кости одного вида
        //            //Две пары — две кости одного вида и две кости другого вида
        //            //Пара — две кости одного вида
        //            //Наивысшее очко
        //        }
        //}
    //}
}
