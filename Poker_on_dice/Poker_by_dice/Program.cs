using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_by_dice
{

    class Program
    {
        static void Main(string[] args)
        {
            bool newgame = true;
            Console.WriteLine("ПОКЕР НА КОСТЯХ v1.0");
            while (newgame)
            {
                Game a = new Game();
                Console.WriteLine("Хотите начать новую игру(true/false):");
                newgame = bool.Parse(Console.ReadLine());
            }
                //ideas(вероятный TODO)
                //главное меню, рекорды(файл), файл конфига(настройки), инструкция(правила).
                // просто мысли:
                // боты(паттерн: перебрасывают те кубы, что не в комбе)//не вышло-проблемы с наследованием
                // создаю список объектов одного класса, добавляю туда сконструированный объект наследного - 
                // создается все равно родительский. получается надо делать отдельно список игроков и ботов -
                // усложнять код + кучу всего переписывать. Непорядок...
        }
    }
}
