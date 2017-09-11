using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyatuchka
{
    class Project
    {
        public string Key { get;private set; }
        public string Title { get; private set; }
        public decimal Initialcost { get; private set; }
        public Customer customer { get; private set; }
        public List<Task> tasks { get; private set; }
        public decimal TotallCost
        {
            get
            {
                decimal sum = 0.0M;
                for(int i = 0; i < tasks.Count; i++)
                {
                    sum = sum + tasks[i].Cost;
                }
                return sum+Initialcost;
            }
        }
        public Project()
        {
            Console.WriteLine("Введите ключевую строку, название и бюджет проекта:");
            Key = Console.ReadLine();
            Title= Console.ReadLine();
            Initialcost= decimal.Parse(Console.ReadLine());
            tasks = new List<Task>();
            Console.WriteLine("Выберите клиента (его порядковый номер)");
            for(int k = 0; k < 2; k++)
            {
                Console.WriteLine($"{k+1}\n{Inf.burg[k]}");
            }
            customer = Inf.burg[int.Parse(Console.ReadLine()) - 1];
        }
        public void AddTask()
        {
            tasks.Add(new Task());
        }
        public void DeleteTask()
        {
            Console.WriteLine("Укажите порядковый номер удаляемой задачи:");
            ListTask();
            tasks.RemoveAt(int.Parse(Console.ReadLine()) - 1);
        }
        public void ListTask()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i+1}. {tasks[i]}");
            }
            return;
        }
        public void ReWriteTask()
        {
            Console.WriteLine("Укажите порядковый номер редактируемой задачи:");
            ListTask();
            tasks[int.Parse(Console.ReadLine()) - 1] = new Task();
        }
    }
}
