using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_2
{
    public class LongInteger
    {
        public string x;
        public LongInteger(string x)
        {
            this.x = x;
        }
        int Length()
        {
            return (Convert.ToString(x)).Length;
        }
        public LongInteger Reverse()
        // Разворот числа, т.к. удобнее считать (не придется каждый раз вставлять цифру в начало при увеличении разрядности числа).
        {
            string a = "";
            for (int i = x.Length - 1; i >= 0; i--)
            {
                a += x[i];
            }
            return new LongInteger(a);
        }
        public string ReverseStr(string b)
        {
            string a = "";
            for (int i = b.Length - 1; i >= 0; i--)
            {
                a += b[i];
            }
            return a;
        }
        public bool StringComparer(string a, string b, bool ravn = false) // check only a>b (a>=b, if ravn==true)
        {
            string a1 = a, b1 = b;
            int z = 0;
            while ((a1[z] == '0') && (z < a1.Length-1))
            {
                z++;
            }
            if (z != 0)
            {
                a1 = a1.Substring(z);
            }
            z = 0;
            while ((b1[z] == '0') && (z < b1.Length-1))
            {
                z++;
            }
            if (z != 0)
            {
                b1 = b1.Substring(z);
            }
            if (a1 == "")
                a1 = "0";
            if (b1 == "")
                b1 = "0";
            if (a1.Length > b1.Length)
                return true;
            if (b1.Length > a1.Length)
                return false;
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] > b1[i])
                    return true;
                if (a1[i] < b1[i])
                    return false;
            }
            if (ravn)
                return true;
            return false;
        }
        private int max(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        private int min(int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }
        public LongInteger Plus(LongInteger a, LongInteger b, bool reverse = true)
        {
            if (reverse)
            {
                a = a.Reverse();
                b = b.Reverse();
            }
            string c = "";
            int z;
            int y = 0;
            if (a.x.Length < b.x.Length)
            {
                c = a.x;
                a.x = b.x;
                b.x = c;
                c = "";
            }
            for (int i = 0; i < b.x.Length; i++)
            {
                z = int.Parse(Convert.ToString(a.x[i])) + int.Parse(Convert.ToString(b.x[i])) + y;
                y = z / 10;
                c += Convert.ToString(z % 10);
            }
            for (int i = b.x.Length; i < a.x.Length; i++)
            {
                z = int.Parse(Convert.ToString(a.x[i])) + y;
                y = z / 10;
                c += Convert.ToString(z % 10);
            }
            if (y != 0)
                c += "1";
            if (reverse)
                return new LongInteger(c).Reverse();
            else
                return new LongInteger(c);
        }

        private LongInteger EasyMultiplied(LongInteger a, int b)
        // Умножение а на одноразрядное число.            
        {
            if (b == 0)
                return new LongInteger("0");

            string c = "";
            int z;
            int y = 0;
            for (int i = 0; i < a.x.Length; i++)
            {
                z = int.Parse(Convert.ToString(a.x[i])) * b + y;
                y = z / 10;
                c += Convert.ToString(z % 10);
            }
            if (y != 0)
                c += Convert.ToString(y);
            return new LongInteger(c);
        }
        public LongInteger ComplexMultiplied(LongInteger a, LongInteger b, bool reverse = true)
        // Обычное умножение.
        {
            if (reverse)
            {
                a = a.Reverse();
                b = b.Reverse();
            }
            string c = "";
            LongInteger r = new LongInteger("0");
            LongInteger b1 = new LongInteger("0");
            if (a.x.Length < b.x.Length)
            {
                c = a.x;
                a.x = b.x;
                b.x = c;
                c = "";
            }
            int k = 0;
            for (int i = 0; i < b.x.Length; i++)
            {
                r = EasyMultiplied(a, int.Parse(Convert.ToString(b.x[i])));
                string s = "";
                for (int j = 0; j < k; j++)
                    s += "0";
                r.x = r.x.Insert(0, s);
                k++;
                b1 = Plus(b1, r, false);
            }
            if (reverse)
                return b1.Reverse();
            else
                return b1;
        }
        public LongInteger Minus(LongInteger a, LongInteger b, bool reverse = true)
        {
            if (a.x == b.x)
                return new LongInteger("0");
            int l = 0;
            while ((b.x[l] == '0'))
            {
                l++;
                if (l == b.x.Length)
                    return a;
            }
            if (reverse)
            {
                a = a.Reverse();
                b = b.Reverse();
            }
            string c = "";
            int z, y = 0;
            for (int i = 0; i < b.x.Length; i++)
            {
                z = int.Parse(Convert.ToString(a.x[i])) - int.Parse(Convert.ToString(b.x[i])) + y;
                if (z < 0)
                {
                    z += 10;
                    y = -1;
                }
                else
                    y = 0;
                c += Convert.ToString(z);
            }
            for (int i = b.x.Length; i < a.x.Length; i++)
            {
                z = int.Parse(Convert.ToString(a.x[i])) + y;
                if (z < 0)
                {
                    z += 10;
                    y = -1;
                }
                else
                    y = 0;
                c += Convert.ToString(z);
            }
            int j = 0;
            while ((c[c.Length - j - 1] == '0') && (j< c.Length))//???
            {
                j++;
            }
            c = c.Remove(c.Length - j, j);
            if (reverse)
                return new LongInteger(c).Reverse();
            else
                return new LongInteger(c);
        }
        public LongInteger Divided(LongInteger a, LongInteger b, bool reverse = false)//????????)
        {
            // деление без остатка.
            if (b.x == "1")
                return a;
            if (reverse)
            {
                a = a.Reverse();
                b = b.Reverse();
            }
            string c = "", n = "", r = "";
            int z, k = 0, x = 1;
            int y = 0,y1=0;
            while (a.x.Length > k)
            {
                //y1 = 0;
                n += Convert.ToString(a.x[k]);
                k++;
                while (a.StringComparer(b.x, n) && (k < a.x.Length))
                {
                    n += Convert.ToString(a.x[k]);
                    if ((y != 0))
                        c += "0";
                    k++;
                }
                //Console.WriteLine();
                //Console.WriteLine(n);
                x = 1;
                while (a.StringComparer(n, b.ComplexMultiplied(b, new LongInteger(Convert.ToString(x))).x, true))
                {
                    x++;
                }
                x--;
                n = Convert.ToString(a.Minus(new LongInteger(n), new LongInteger(Convert.ToString(int.Parse(b.x) * x))).x);
                z = 0;
                //Console.WriteLine(n);
                while ((n[z] == '0') && (z < n.Length-1))
                {
                    z++;
                }
                if (z != 0)
                {
                    n = n.Substring(z);
                }
                if (n[0] == '0')
                    n = n.Remove(0, 1);
                //Console.WriteLine(n);
                c += Convert.ToString(x);
                y++;
            }

            if (reverse)
                return new LongInteger(c).Reverse();
            else
                return new LongInteger(c);
        }
        public LongInteger PowInteger(LongInteger a, LongInteger k)
        {
            LongInteger b = new LongInteger("1");
            HashSet<char> hsh = new HashSet<char>();
            foreach (char i in "02468")
                hsh.Add(i);
            while (a.StringComparer(k.x, "0"))
            {
                if (hsh.Contains(k.x[k.x.Length - 1]))
                {
                    k = k.Divided(k, new LongInteger("2"));
                    a = a.ComplexMultiplied(a, a);
                }
                else
                {
                    k = k.Minus(k, new LongInteger("1"));
                    b = b.ComplexMultiplied(b, a);
                }
            }
            return b;
        }
        public LongInteger Karatsuba(LongInteger a, LongInteger b, bool reverse = false)
        {
            if (reverse)
            {
                a = a.Reverse();
                b = b.Reverse();
            }
            int n = a.min(a.x.Length, b.x.Length);
            int u = a.max(a.x.Length, b.x.Length);
            if (n == 1)
                return ComplexMultiplied(a, b);
            string k = "";
            for (int i = 1; i <= (n / 2) * 2; i++)
                k += "0";
            LongInteger f1, f2, f3, f4 = new LongInteger("");
            string x1 = a.x.Substring(0, a.x.Length - n / 2), x2 = a.Reverse().x.Substring(0, n / 2), y1 = b.x.Substring(0, b.x.Length - n / 2), y2 = b.Reverse().x.Substring(0, n / 2);
            x2 = a.ReverseStr(x2);
            y2 = a.ReverseStr(y2);
            f1 = Karatsuba(new LongInteger(x1), new LongInteger(y1));
            f2 = Karatsuba(new LongInteger(x2), new LongInteger(y2));
            f3 = Karatsuba(Plus(new LongInteger(x1), new LongInteger(x2)), Plus(new LongInteger(y1), new LongInteger(y2)));
            f1 = Plus(Plus(new LongInteger(f1.x + k), new LongInteger(Minus(f3, Plus(f1, f2)).x + k.Substring(0, n / 2))), f2);
            if (reverse)
                return f1.Reverse();
            else
                return f1;
        }
    }
}
