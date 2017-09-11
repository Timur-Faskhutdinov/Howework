using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyatuchka
{
    class Employee
    {
        public int number { get; private set; }
        public string Fullname { get; private set; }
        private int _rating;
        public int rating
        {
            get { return _rating; }
            private set { _rating = (value > 0 && value < 6) ? value : 1; }
        }
        public Position position { get; private set; }
        public decimal Hourlyrate
        {
            get
            {
                return position.basehourlyrate * (decimal)(1.0 + rating * 0.05);
            }
        }
        public Employee()
        {
            Console.WriteLine("Введите номер сотрудника, его полное имя и ранг");
            number = int.Parse(Console.ReadLine());
            Fullname = Console.ReadLine();
            rating = int.Parse(Console.ReadLine());
            Inf.ListPos();
            position = Inf.posit[int.Parse(Console.ReadLine()) - 1];
        }
        public Employee(int number, string Fullname, int rating, Position position)
        {
            this.number=number;
            this.Fullname=Fullname;
            _rating=rating;
            this.position = position;
        }
        public override string ToString()
        {
            return String.Format($"Табельный номер: {number}\nИмя: {Fullname}\nРанг {rating}\nДолжность {position}\nПочасовой оклад: {Hourlyrate}\n");
        }
    }
}
