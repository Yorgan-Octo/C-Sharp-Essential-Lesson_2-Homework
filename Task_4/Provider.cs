using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Provider
    {

        private readonly int id;

        public string Name { get; set; }
        public string Namber { get; set; }

       public Provider(string name, string namber)
        {
            this.id = new Random().Next(1000, 9999);
            Name = name;
            Namber = namber;
        }

        public void ShowInfo()
        {
            Console.WriteLine(new String('-', 80));
            Console.WriteLine("Постачальник:");
            Console.WriteLine($"Назва: {Name} | Тел. {Namber}");
            Console.WriteLine(new String('-', 80));
        }
    }
}
