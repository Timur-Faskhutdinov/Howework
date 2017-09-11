using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyatuchka
{
    static class Inf
    {
        public static List<Position> posit { get; private set; }
        public static List<Employee> slav { get; private set; }
        public static List<Customer> burg { get; private set; }
        public static void doit()
        {
            posit = new List<Position>();
            slav = new List<Employee>();
            burg = new List<Customer>();
            posit.Add(new Position("gg777", "Ведущий ничегонеделатель", 3000.0M));
            posit.Add(new Position("ggwp", "Местный индус", 400.0M));
            posit.Add(new Position("gghf", "Стажер", 80.0M));
            slav.Add(new Employee(1,"Сергей Сергеевич Кофемашина",3,posit[0]));
            slav.Add(new Employee(4, "Андрей Андреевич Выходной", 4, posit[0]));
            slav.Add(new Employee(13, "Абдурахман Алибабаевич Дедлайн", 5, posit[1]));
            slav.Add(new Employee(42, "Альберт Моисеевич Засколько", 4, posit[1]));
            slav.Add(new Employee(1337, "Эдуард Эдуардович Красный", 5, posit[2]));
            slav.Add(new Employee(1, "Константин Константинович Эфемерный", 2, posit[2]));
            slav.Add(new Employee(1, "Дмитрий Дмитриевич Клешня ", 1, posit[2]));
            burg.Add(new Customer("ООО \"Клешни и Панцири\"","Федор Федорович Гусевод","prawns@moidodur.com",2551188));
            burg.Add(new Customer("ООО \"Великое Прозрение\"", "Архаон Архаонович Энтропия", "endoftime@moidodur.com", 2999666));
        }
        public static void ListEmp()
        {
            Console.WriteLine("Список доступных сотрудников, введите порядковый номер нужного");
            for(int i = 0; i < slav.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {slav[i]}");
            }
            return;
        }
        public static void ListCl()
        {
            Console.WriteLine("Список доступных клиентов, введите порядковый номер нужного");
            for (int i = 0; i < slav.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {burg[i]}");
            }
            return;
        }
        public static void ListPos()
        {
            Console.WriteLine("Список должностей, введите порядковый номер нужной");
            for (int i = 0; i < slav.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {posit[i]}");
            }
            return;
        }
    }
}
