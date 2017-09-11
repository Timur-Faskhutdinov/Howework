using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyatuchka
{
    class Customer
    {
        public string conctatcemail { get; set; }
        public string concatperson { get; set; }
        public int concatphone { get; set; }
        public string name { get; set;}
        public Customer()
        {
            Console.WriteLine("Введите наименование, ФИО, телефон, электронную почту клиента");
        }
        public Customer(string n, string prs, string e, int ph)
        {
            name = n;
            concatperson = prs;
            conctatcemail = e;
            concatphone = ph;
        }
        public override string ToString()
        {
            return String.Format($" {name}\nконтактное лицо:{concatperson}\nконтактный телефон: {concatphone}\nадресс электронной почты: {conctatcemail}");
        }
    }
}
