using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyatuchka
{
    class Program
    {
        static void Main(string[] args)
        {
            Inf.doit();
            Project prj = new Project();
            int f = 1;
            while (f != 0)
            {
                Console.WriteLine("Выберите действие:\n 0 - выйти из программы\n 1 - добавить задачу\n 2 - редактировать задачу\n 3 - удалить задачу\n 4 - показать стоимость проекта\n 5 - показать текущие задачи");
                f = int.Parse(Console.ReadLine());
                switch (f)
                {
                    case 0:
                        break;
                    case 1:
                        prj.AddTask();
                        break;
                    case 2:
                        prj.ReWriteTask();
                        break;
                    case 3:
                        prj.DeleteTask();
                        break;
                    case 4:
                        Console.WriteLine(prj.TotallCost);
                        break;
                    case 5:
                        prj.ListTask();
                        break;
                    default:
                        Console.WriteLine("Некорректная команда. Введите еще раз.");
                        break;
                }
            }
            // Да, как я понял из описания задачи, пени начисляется, если задача оплачивается отдельно, и вычитается из стоимости задачи (т.е. работник получит
            // меньше денег, если завалит дедлайн). Если понял не правильно - сильно не пинайте.
        }
    }
}
