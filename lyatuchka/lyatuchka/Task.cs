using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyatuchka
{
    class Task
    {
        public int Number { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime CloseDate { get; private set; }
        public decimal HoursSpent { get; private set; }
        public bool Billable { get; private set; }
        public Employee Responsible { get; private set; }
        public decimal Cost
        {
            get
            {
                if (!Billable)
                    return 0.0M;
                decimal x = Convert.ToDecimal(CloseDate.Subtract(DueDate).TotalDays);
                x = x > 25.0M ? 25.0M : x;
                return (decimal)(HoursSpent * Responsible.Hourlyrate) * (1.0M - x / 100);
            }
        }
        public Task()
        {
            //int number, string des, DateTime duedate, DateTime close, decimal hspent, bool bill,
            //вводится извне
            Console.WriteLine("Введите номер задачи, её описание, срок исполнения, дату завершения работ, затраты времени, отдельно ли оплачивается задача:");
            Number = int.Parse(Console.ReadLine());
            Description = Console.ReadLine();
            DueDate = DateTime.Parse(Console.ReadLine());
            CloseDate = DateTime.Parse(Console.ReadLine());
            HoursSpent = decimal.Parse(Console.ReadLine());
            Billable = bool.Parse(Console.ReadLine());
            Inf.ListEmp();
            Responsible = Inf.slav[int.Parse(Console.ReadLine())-1];
        }
        public override string ToString()
        {
            string s = Billable ? "Оплачивается отдельно" : "Входит в бюджет";
            return String.Format($"\nНомер: {Number}\nОписание: {Description}\nСрок исполнения: {DueDate}\nДата завершения работ: {CloseDate}\nЗатраты времени: {HoursSpent}\n {s}\n Ответсвенный: {Responsible}");
        }
        //public void ReWrite()
        //{

        //}
    }
}
