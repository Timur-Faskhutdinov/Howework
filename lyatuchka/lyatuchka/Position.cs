using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyatuchka
{
    class Position
    {
        string code { get; set; }
        string name { get; set; }
        public decimal basehourlyrate { get;private set; }
        public Position(string code,string name,decimal basehourlyrate)
        {
            this.code = code;
            this.name = name;
            this.basehourlyrate = basehourlyrate;
        }
        public Position()
        {
            Console.WriteLine("Введите код должности, наименование и базовую ставку");
            code = Console.ReadLine();
            name = Console.ReadLine();
            basehourlyrate = decimal.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return String.Format($"{name} ({code})");
        }
    }
}
