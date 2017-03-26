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
                s.Append("V");
            }
            s.Remove(s.Length - 1, 1);
            return s.ToString();
        }
        public void Insert(Konj k)
        {
            if (!KList.Contains(k)) // check
            {
                KList.Add(k);
            }
            return;
        }
        public DNF Disj(DNF d)
        {
            return d;
        }
        public bool value(bool[] v)
        {
            return true;
        }
        public void SortByLength()
        {

        }
        public DNF DNFWith(int i)
        {
            return this;
        }
    }
    class Konj : IEquatable<Konj>,IComparable<Konj>
    {
        public List<int> ArLst;
        public Konj(string a)
        {
            ArLst = new List<int>();
            List<string> d = a.Split('&').ToList();
            int y = 1;
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

        public int CompareTo(Konj other)
        {
            return ToString().Length.CompareTo(other.ToString().Length); // если сравнивает не в ту сторону - прерставить экземпляры.
        }

        public bool Equals(Konj other)
        {
            //throw new NotImplementedException();
            return Equals(ArLst, other.ArLst);
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            foreach (int j in ArLst)
            {
                if (j > 0)
                {
                    s.AppendFormat($"{0}X{1}&", j > 0 ? "" : "-", Math.Abs(j)); // чекнуть
                }
            }
            s.Remove(s.Length - 1, 1);
            return s.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
//в процессе разработки
        }
    }
}
