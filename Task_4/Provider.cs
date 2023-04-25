using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Provider
    {

        private readonly int id = new Random().Next(1000, 9999);

        public string Name { get; set; }
        public int Namber { get; set; }

       public Provider(int id, string name, int namber)
        {
            Name = name;
            Namber = namber;
        }

        public void ShowInfo()
        {
            Console.WriteLine(new String('-', 80));
            Console.WriteLine($"Постачальник: {Name} | Тел. {Namber}");
            Console.WriteLine(new String('-', 80));
        }
    }
}
