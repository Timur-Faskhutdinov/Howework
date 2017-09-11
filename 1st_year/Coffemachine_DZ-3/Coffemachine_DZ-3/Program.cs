using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemachine_DZ_3
{
    public class CoffeMachine
    {
        public CoffeMachine()
        {
            bool vend=true;
            if((Storage.coffe<10.0)||(Storage.sugar < 10.0) ||(Storage.milk < 50.0) ||(Storage.water < 500.0)||(Storage.Nicght))
            {
                CallSupport();
            }
            Console.WriteLine("Выберите товар");
            int i = 0;
            string s;
            foreach(KeyValuePair<string,decimal> k in Assort.coffelist)
            {
                i++;
                Console.WriteLine($"{i} - {k.Key} стоимостью {k.Value} тугриков");
            }
            foreach (KeyValuePair<string, decimal> k in Assort.vending)
            {
                i++;
                Console.WriteLine($"{i} - {k.Key} стоимостью {k.Value} тугриков");
            }
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    s = Assort.coffelist.Keys.ToList()[0];
                    vend = false;
                    break;
                case 2:
                    s = Assort.coffelist.Keys.ToList()[1];
                    vend = false;
                    break;
                case 3:
                    s = Assort.coffelist.Keys.ToList()[2];
                    vend = false;
                    break;
                case 4:
                    s = Assort.vending.Keys.ToList()[0];
                    break;
                case 5:
                    s = Assort.vending.Keys.ToList()[1];
                    break;
                case 6:
                    s = Assort.vending.Keys.ToList()[2];
                    break;
                case 7:
                    s = Assort.vending.Keys.ToList()[3];
                    break;
                case 8:
                    s = Assort.vending.Keys.ToList()[4];
                    break;
                case 9:
                    s = Assort.vending.Keys.ToList()[5];
                    break;
                default:
                    return;
            }
            Money mn = new Money(Assort.coffelist.ContainsKey(s) ? Assort.coffelist[s] : Assort.vending[s]);
            if (mn.sum >= (Assort.coffelist.ContainsKey(s) ? Assort.coffelist[s] : Assort.vending[s]))
            {
                if (Money.TrySdacha(mn.sum - (Assort.coffelist.ContainsKey(s) ? Assort.coffelist[s] : Assort.vending[s])))
                {
                    Money.Sdacha(mn.sum - (Assort.coffelist.ContainsKey(s) ? Assort.coffelist[s] : Assort.vending[s]));
                    if (vend)
                    {
                        Console.WriteLine($"Возьмите свой {s}\nПриятного аппетита!");
                    }
                    else
                    {
                        Cup ch = new Cup(s);
                        ch.Create();
                    }
                }
                else
                {
                    Console.WriteLine("В автомате отсутствует сдача. Попробуйте еще раз.");
                    Money.Sdacha(mn.sum);
                    return;
                }
            }
            else
            {
                Console.WriteLine("Недостаточно денег. Попробуйте снова.");
                Money.Sdacha(mn.sum);
                return;
            }
        }
        public void CallSupport()
        {
            Storage.AppearSuply();
        }
    }
    public class Cup
    {
        public bool iswater;
        //public bool ishot;
        //public bool ismilk;
        //public bool ispena;
        //public string coffetype;
        public Milk m;
        public Water w;
        public Sugar s;
        public string porosh;
        public Cup(string s)
        {
            iswater = false;
            porosh = s;
        }
        public void Create()
        {
            Console.WriteLine("Cup is ermty");
            Storage.coffe -= Inf.consist[porosh][2];
            Console.WriteLine(String.Format($"Cup is filled by {Inf.consist[porosh][2]}gramm coffe"));
            w = new Water(Inf.consist[porosh][0]);
            Console.WriteLine(String.Format($"Cup prepare be filled by {Inf.consist[porosh][0]}ml cold water"));
            w.Podogrev();
            Console.WriteLine("Now water is hot and go to cup");
            m = new Milk(Inf.consist[porosh][1]);
            Console.WriteLine(String.Format($"Cup is filled by {Inf.consist[porosh][1]}ml milk"));
            s = new Sugar();
            Console.WriteLine(String.Format($"{s.valui} gramm of sugar was delivered into the cup"));
            Console.WriteLine("Your coffe is ready!");
        }
    }
    public class Inf
    {
        public static Dictionary<string, double[]> consist= new Dictionary<string, double[]>();
        public static void Add()
        {
            consist.Add("kapuchino", new double[] {180.0,40.0,5.0}); // water-milk-poroshok
            consist.Add("espresso", new double[] { 185.0, 35.0,4.0 });
            consist.Add("hot_chocolad", new double[] { 170.0, 50.0, 8.0});
        }
    }
    public static class Assort
    {
        public static Dictionary<string, decimal> coffelist= new Dictionary<string, decimal>();
        public static Dictionary<string, decimal> vending = new Dictionary<string, decimal>();
        public static void Add()
        {
            coffelist.Add("kapuchino", 12.7M);
            coffelist.Add("espresso", 15.5M);
            coffelist.Add("hot_chocolad", 8.1M);
            vending.Add("butelka vody", 3.7M);
            vending.Add("snikersni", 4.1M);
            vending.Add("kirieshky", 3.5M);
            vending.Add("layz", 5.0M);
            vending.Add("sok", 7.7M);
            vending.Add("cola", 4.5M);

        }
    }
    public static class Storage
    {
        public static double milk = 10000.0; //millilitr
        public static double water = 100000.0; // -||-
        public static double sugar = 1000.0; // gramm
        public static double coffe = 1000.0; // gramm
        public static int voda = 25;
        public static int snikers = 25;
        public static int suhariki = 25;
        public static int chipse = 25;
        public static int sok = 25;
        public static int cola = 25;
        public static void AppearSuply()
        {
            milk = 1000000.0; //millilitr
            water = 100000.0; // -||-
            sugar= 1000.0; // gramm
            coffe = 1000.0; // gramm
            voda = 25;
            snikers = 25;
            suhariki = 25;
            chipse = 25;
            sok = 25;
            cola = 25;
    }
        public static bool Nicght
        {
            get
            {
                if ((voda == 0) || (snikers == 0) || (suhariki == 0) || (chipse == 0) || (sok == 0) || (cola == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
    public class Milk
    {
        public double value;
        //public bool ispena;       
        public Milk(double g)
        {
            value = g;
            Storage.milk -= g;
            //ispena = false;
        }
        //public void Mikser()
        //{
        //    ispena = true;
        //}
    }
    public class Water
    {
        public double value=0; //!!!
        public bool ishot;
        public Water(double g)
        {
            value = g;
            ishot = false;
            Storage.water -= g;
        }
        public void Podogrev()
        {
            ishot = true;
        }
    }
    public class Money
    {
        public static decimal bigmoney = 0.0M;
        public static int tu_10 = 10;
        public static int tu_5 = 10;
        public static int tu_2 = 10;
        public static int tu_1 = 10;
        public static int cent_50 = 10;
        public static int cent_10 = 10;
        public static decimal Value
        {
            get
            {
                return (decimal)(bigmoney + tu_10 * 10 + tu_5 * 5 + tu_2 * 2 + tu_1 + Convert.ToDecimal(cent_50 *0.5) + Convert.ToDecimal(cent_10 * 0.1));
            }
        }
        public static bool TrySdacha(decimal f)
        {
            decimal w = 0.0M;
            if (0.5M <= f)
            {
                w += (decimal)(cent_50) / 2;
            }
            if (1.0M <= f)
            {
                w += (decimal)(tu_1);
            }
            if (2.0M <= f)
            {
                w += (decimal)(tu_2) * 2;
            }
            if (5.0M <= f)
            {
                w += (decimal)(tu_5) * 5;
            }
            if (10.0M <= f)
            {
                w += (decimal)(tu_10) * 10;
            }
            if (f <= w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public decimal sum;
        public Money(decimal rt)
        {
            sum = 0.0M;
            Console.WriteLine("Хотите оплатить картой?");
            if (bool.Parse(Console.ReadLine()))
            {
                Console.WriteLine("Вставте карту");
                Console.ReadLine();
                Console.WriteLine("Введите пин-код");
                Console.ReadLine();
                sum = rt;
                bigmoney += rt;
                Console.WriteLine("Оплата произведена. Возьмите карту.");
                Console.ReadLine();
            }
            else
            {
            Console.WriteLine("Вставьте монетку\n0 - закончить ввод\n1 - 10 центов\n2 - 50центов\n3 - 1 тугрик");
            Console.WriteLine("4 - 2 тугрика\n5 - 5 тугриков\n6 - 10 тугриков\n7 - 50 тугриков");
            int k = 1;
                while (k != 0)
                {
                    k = int.Parse(Console.ReadLine());
                    switch (k)
                    {
                        case 0:
                            break;
                        case 1:
                            enter_cent_10();
                            break;
                        case 2:
                            enter_cent_50();
                            break;
                        case 3:
                            enter_tu_1();
                            break;
                        case 4:
                            enter_tu_2();
                            break;
                        case 5:
                            enter_tu_5();
                            break;
                        case 6:
                            enter_tu_10();
                            break;
                        case 7:
                            bigmoney += 50.0M;
                            sum += 50.0M;
                            break;
                        default:
                            Console.WriteLine("Монета неопознанного формата.");
                            break;
                    }
                }
            }
        }
        public static void Sdacha(decimal s)
        {
            while ((s >= 10.0M) && (tu_10 > 0))
            {
                Console.WriteLine("Вы получили 10 тугриков");
                s -= 10.0M;
                tu_10--;
            }
            while ((s >= 5.0M) && (tu_5 > 0))
            {
                Console.WriteLine("Вы получили 5 тугриков");
                s -= 5.0M;
                tu_5--;
            }
            while ((s >= 2.0M) && (tu_2 > 0))
            {
                Console.WriteLine("Вы получили 2 тугрика");
                s -= 2.0M;
                tu_2--;
            }
            while ((s >= 1.0M) && (tu_1 > 0))
            {
                Console.WriteLine("Вы получили 1 тугрик");
                s -= 1.0M;
                tu_1--;
            }
            while ((s >= 0.5M) && (cent_50 > 0))
            {
                Console.WriteLine("Вы получили 50 центов");
                s -= 0.5M;
                cent_50--;
            }
            while ((s >= 0.1M) && (cent_10 > 0))
            {
                Console.WriteLine("Вы получили 10 центов");
                s -= 0.1M;
                cent_10--;
            }
        }
        public void enter_tu_10()
        {
            tu_10++;
            sum += 10.0M;
            return;
        }
        public void enter_tu_5()
        {
            tu_5++;
            sum += 5.0M;
            return;
        }
        public void enter_tu_2()
        {
            tu_2++;
            sum += 2.0M;
            return;
        }
        public void enter_tu_1()
        {
            tu_1++;
            sum += 1.0M;
            return;
        }
        public void enter_cent_50()
        {
            cent_50++;
            sum += 0.5M;
            return;
        }
        public void enter_cent_10()
        {
            cent_10++;
            sum += 0.1M;
            return;
        }
    }
    public class Sugar
    {
        private double _valui;
        public double valui
        {
            get { return _valui; }
            private set
            {
                _valui = value;
                if (value > 5.0)
                {
                    _valui = 5.0;
                }
                if (value < 0.0)
                {
                    _valui = 0.0;
                }
            }
        }
        public Sugar()
        {
            Console.WriteLine("Желаемое количество сахара(максимально 5 гр)");
            valui = double.Parse(Console.ReadLine());
            Storage.sugar -= valui;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Assort.Add();
            Inf.Add();
            bool f = true;
            while (f)
            {
                Console.WriteLine("Хотите еще что-нибудь? (boolean)");
                f = bool.Parse(Console.ReadLine());
                if (f)
                {
                    CoffeMachine a = new CoffeMachine();
                }
            }
        }
    }
}
