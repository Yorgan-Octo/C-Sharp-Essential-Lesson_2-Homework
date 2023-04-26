using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Сustomer
    {
        private readonly int id;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Namber { get; set; }


        public Сustomer(string name, string lastName, string namber)
        {
            this.id = new Random().Next(1000, 9999);
            Name = name;
            LastName = lastName;
            Namber = namber;
        }

        public void ShowInfo()
        {
            Console.WriteLine(new String('-',80));
            Console.WriteLine("Клиент:");
            Console.WriteLine($"ФІО {Name} {LastName} | Тел. {Namber}");
            Console.WriteLine(new String('-', 80));
        }

    }
}
