using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Semesdtrovka_1
{
    class DNF
    {
        List<Konj> KList;
        public DNF()
        {
            KList = new List<Konj>();
        }
        public DNF(string s)
        {
            List<string> k = s.Split('V').ToList();
            KList = new List<Konj>();
            foreach(string i in k)
            {
                KList.Add(new Konj(i));
            }
        }
        public override string ToString()
        {
            //string non="", min = "-";
            StringBuilder s = new StringBuilder();
            foreach(Konj i in KList)
            {
                //foreach(int j in i.ArLst)
                //{
                //    if (j > 0)
                //    {
                //        s.AppendFormat($"{0}X{1}&", j > 0 ? "" : "-",Math.Abs(j)); // чекнуть
                //    }
                //}
                //s.Remove(s.Length - 1, 1);
                s.Append(i.ToString());
                s.Append(" V ");
            }
            s.Remove(s.Length - 3, 3);
            return s.ToString();
        }
        public void Insert(Konj k,bool f=false)
        {
            // Какая-то ересь. Метод работает прямо противоположно, если вызвать его напрямую, он добавит элемент если
            // он уже есть в списке и наоборот, не добавит, если его нет. через метод Disj работает корректно.
            // Пришлось запилить костыль-флаг.
            // разобрался - нужна своя реализация contain!!!
            if ((KList.Contains(k)==true)&(f==false)||(f==true)&(KList.Contains(k) == false)) // check
            {
                KList.Add(k);
            }
            //Console.WriteLine(KList[0].ToString().Equals(k.ToString()));
            return;
        }
        public static DNF Disj(DNF a,DNF b)
        {
            DNF w = new DNF();
            w.KList = a.KList;
            foreach(Konj i in b.KList)
            {
                w.Insert(i,true);
            }
            return w;
        }
        public bool Value(bool[] a)
        {
            bool f = false;
            foreach(Konj i in KList)
            {
                f = f | i.Value(a);
            }
            return f; //!!!!
        }
        public void SortByLength()
        {
            KList.Sort();
        }
        public static DNF DNFWith(DNF a,int i)
        {
            DNF w = new DNF();
            w.KList = a.KList;
            foreach(Konj q in w.KList)
            {
                q.AppendX(i);
            }
            return w;
        }
    }
    class Konj : IComparable<Konj>,IEqualityComparer<Konj>
    {
        public List<int> ArLst;
        public Konj(string a)
        {
            ArLst = new List<int>();
            List<string> d = a.Split('&').ToList();
            //int y = 1;
            foreach (string j in d)
            {
                if (j[0] == '-')
                {
                    ArLst.Add(Convert.ToInt32(string.Format($"-{j[2]}")));
                }
                else
                {
                    ArLst.Add(Convert.ToInt32(string.Format($"{j[1]}")));
                }
            }
        }
        public bool Value(bool[] a)
        {
            bool f = true,d;
            foreach(int i in ArLst)
            {
                if (i > 0)
                {
                    d = true;
                }
                else
                {
                    d = false;
                }
                if (!a[Math.Abs(i) - 1])
                {
                    if (d)
                    {
                        d = false;
                    }
                    else
                    {
                        d = true;
                    }
                }
                f = f & d;
                if (!f)
                {
                    return false;
                }
            }
            return f;
        }
        public void AppendX(int i)
        {
            if (!ArLst.Contains(Math.Abs(i)))
            {
                ArLst.Add(i);
            }
        }

        public int CompareTo(Konj other)
        {
            return ToString().Length.CompareTo(other.ToString().Length); // если сравнивает не в ту сторону - прерставить экземпляры.
        }

        //public bool Equals(Konj other)
        //{
        //    //throw new NotImplementedException();
        //    return Equals(ArLst, other.ArLst);
        //}
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            foreach (int j in ArLst)
            {
                //if (j > 0)
                //{
                    //string r = j > 0 ? "" : "-";
                //Console.WriteLine(r);
                    s.AppendFormat(String.Format("{0}X{1}&", j > 0 ? "" : "-", Math.Abs(j))); // чекнуть
                //}
            }
            s.Remove(s.Length - 1, 1);
            return s.ToString();
        }

        public bool Equals(Konj x, Konj y)
        {
            //throw new NotImplementedException();
            return Equals(x.ToString(), y.ToString());
            //return x.ToString().Equals(y.ToString());
        }

        public int GetHashCode(Konj obj)
        {
            //throw new NotImplementedException();
            return obj.ToString().GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // реализовать contain для insert!!!
            DNF a = new DNF(Console.ReadLine());
            DNF b = new DNF(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine("Check insert");
            a.Insert(new Konj(Console.ReadLine()));
            Console.WriteLine(a);
            Console.WriteLine("Check disjunc");
            Console.WriteLine(DNF.Disj(a, b));
            Console.WriteLine("Check calculate");
            bool[] c = new bool[5];
            for(int i=0;i<5;i++)
            {
                c[i] = bool.Parse(Console.ReadLine());
            }
            Console.WriteLine(a.Value(c));
            Console.WriteLine("Check sort");
            a.SortByLength();
            Console.WriteLine(a);
            Console.WriteLine("Check dnfWith");
            Console.WriteLine(DNF.DNFWith(a, int.Parse(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
