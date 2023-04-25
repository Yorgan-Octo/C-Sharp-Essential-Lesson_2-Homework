using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Сustomer
    {
        private readonly int id = new Random().Next(1000,9999);

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Namber { get; set; }


        public Сustomer(int id, string name, string lastName, int namber)
        {
            Name = name;
            LastName = lastName;
            Namber = namber;
        }

        public void ShowInfo()
        {
            Console.WriteLine(new String('-',80));
            Console.WriteLine($"Клиент: {Name} {LastName} | Тел. {Namber}");
            Console.WriteLine(new String('-', 80));
        }

    }
}
