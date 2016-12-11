using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_2
{
    class LongDecimal
    {
        public LongInteger m;
        public int e;
        public bool z;
        public bool nul;
        public LongDecimal(string m, int e)
        {
            this.z = true;
            if (m[0] == '-')
            {
                this.z = false;
                m = m.Remove(0, 1);
            }
            string[] a = new string[2];
            a = m.Split(',', '.');
            this.m = new LongInteger(a[0] + a[1]);
            this.e = e - a[1].Length;
            this.nul = false;
        }
        public void Adduction(ref LongDecimal a, ref LongDecimal b) // Приведение к одному порядку еxp.
        {
            //if ((a.m.Length + a.e) == (b.m.Length + b.e))
            //    return;
            if ((a.e) == (b.e))
                return;
            LongDecimal c = a;
            bool f = true;
            if ((a.e) < (b.e))
            {
                c = b;
                f = false;
            }
            int w = Math.Abs(a.e - b.e);
            string s = "";
            for (int i = 1; i <= w; i++)
            {
                s += "0";
            }
            c.m.x += s;
            c.e -= w;
            if (f)
                a = c;
            else
                b = c;
            return;
        }
        public LongDecimal Reduction(LongDecimal a) // Сокращение мантисы (нули в exp).
        {
            int i = 0;
            if (a.m.x.Length == 1)
                return a;
            while (a.m.x[a.m.x.Length - 1 - i] == '0')
            {
                i++;
                a.e++;
                //if (i == a.m.x.Length)
                //{
                //    a.m.x = "0";
                //    a.e = 0;
                //    a.nul = true;
                //    return a;
                //}
            }
            if(i!=0)
                a.m.x = a.m.x.Remove(a.m.x.Length - i, i);
            return a;
        }
        public LongDecimal Plus(LongDecimal a, LongDecimal b)
        {
            a.Adduction(ref a, ref b);
            LongDecimal c = new LongDecimal("1.0", a.e);
            c.e = a.e;
            if (a.z && b.z)
                c.m = c.m.Plus(a.m, b.m);
            if(!(a.z || b.z))
            {
                c.m = c.m.Plus(a.m, b.m);
                c.z = false;
            }
            if (!a.z && b.z)
                c = c.Minus(b, a);
            if (a.z && !b.z)
                c = c.Minus(a, b);
            a = Reduction(a);
            b = Reduction(b);
            c = c.Reduction(c);
            return c;
        }
        public LongDecimal Minus(LongDecimal a, LongDecimal b)
        {
            a.Adduction(ref a, ref b);
            LongDecimal c = new LongDecimal("1.0", a.e);
            c.e = a.e;
            if (a.m.StringComparer(b.m.x,a.m.x))
            {
                c = new LongDecimal("-1.0", a.e);
                c.e = a.e;
                c.m = c.m.Minus(b.m, a.m);
            }
            else
                c.m = c.m.Minus(a.m, b.m);

            c = c.Reduction(c);
            return c;
        }
        public void Print(LongDecimal b)
        {
            LongDecimal a=new LongDecimal("1.0",0);
            a.m = b.m;
            a.e = b.e;
            a.z = b.z;
            string q="",s="";
            int i = a.m.x.Length - 1;
            if (!z)
                q = "-";
            s = a.m.x.Substring(1, i);
            a.e += (i);
            Console.WriteLine("{0}{1}.{2}e{3}", q, a.m.x[0],s, a.e);
            return;
        }
        public LongDecimal Multip(LongDecimal a, LongDecimal b)
        {
            LongDecimal c = new LongDecimal("1.0", 0);
            c.m = c.m.ComplexMultiplied(a.m, b.m);
            c.z = true;
            if (a.z != b.z)
                c.z = false;
            c.e = a.e + b.e;
            c = c.Reduction(c);
            return c;
        }
        public LongDecimal Divided(LongDecimal a, LongDecimal b, int p=5)
        {
            //Console.WriteLine();
            //Console.WriteLine($"{b.m.x} {b.e}");
            LongDecimal c = new LongDecimal("1.0", 0);
            c.z = true;
            if (a.z != b.z)
                c.z = false;
            while (a.m.x.Length/b.m.x.Length < (p))
            {
                a.m.x += "0";
                a.e--;
            }
            c.e = a.e - b.e;
            Console.WriteLine($"{a.m.x} {a.e} {b.m.x} {b.e}");
            c.m = c.m.Divided(a.m, b.m);
            //Console.WriteLine($"{c.m.x} {c.e}");
            c = c.Reduction(c);
            //a = Reduction(a);
            //b = Reduction(b);
            return c;
        }
        public LongDecimal IntPow(LongDecimal a, LongInteger k)
        {
            LongDecimal b = new LongDecimal("1.0",1);
            HashSet<char> hsh = new HashSet<char>();
            foreach (char i in "02468")
                hsh.Add(i);
            while (k.StringComparer(k.x, "0"))
            {
                if (hsh.Contains(k.x[k.x.Length - 1]))
                {
                    k = k.Divided(k, new LongInteger("2"));
                    a = a.Multip(a, a);
                }
                else
                {
                    k = k.Minus(k, new LongInteger("1"));
                    b = b.Multip(b, a);
                }
            }
            return b;
        }
        public LongDecimal DoublePow(LongDecimal a,LongDecimal k, int accuracy = 50)
        {
            LongDecimal s = new LongDecimal("1.0", 0);
            LongDecimal t = new LongDecimal("1.0", -1);
            LongDecimal y = new LongDecimal("1.0", 0);
            LongDecimal fact = new LongDecimal("1.0", 0);
            LongDecimal pow =a.Minus( a,new LongDecimal("1.0",0));
            int i = 0;

            while (s.Minus(y, t).e > (-accuracy))
            {
                fact = t.Multip(fact, t.Minus(k, new LongDecimal(Convert.ToString(i) + ".0", 0)));
                i++;
                fact = t.Multip(fact, pow);
                if (i != 1)
                    fact = t.Divided(fact, new LongDecimal(Convert.ToString(i) + ".0", 0), accuracy);
                s = s.Plus(s, fact);
                t = y;
                y = fact;
                if ((t.Reduction(t).m.x == "0") && (t.Reduction(t).e == 0))
                    break;
            }
            return s;
        }

        //public LongDecimal DoubleSqrt(LongDecimal a, int accuracy = 50)
        //{
        //    LongDecimal k = new LongDecimal("0.5", 0);
        //    LongDecimal s = new LongDecimal("1.0", 0);
        //    LongDecimal t = new LongDecimal("1.0", -1);
        //    LongDecimal y = new LongDecimal("1.0", 0);
        //    LongDecimal fact = new LongDecimal("1.0", 0);
        //    LongDecimal pow = a.Minus(a, new LongDecimal("1.0", 0));
        //    int i = 0;

        //    while (s.Minus(y, t).e > (-accuracy))
        //    {
        //        fact = t.Multip(fact, t.Minus(k, new LongDecimal(Convert.ToString(i) + ".0", 0)));
        //        i++;
        //        fact = t.Multip(fact, pow);
        //        if (i != 1)
        //            fact = t.Divided(fact, new LongDecimal(Convert.ToString(i) + ".0", 0), accuracy);
        //        s = s.Plus(s, fact);
        //        t = y;
        //        y = fact;
        //        if ((t.Reduction(t).m.x == "0") && (t.Reduction(t).e == 0))
        //            break;
        //    }
        //    return s;
        //}
    }
}
