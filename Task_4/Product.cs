using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Product
    {
        public int Article { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int price, int quantity)
        {
            Article = new Random().Next(100,1000);
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void ShowInfoProduct()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new String('-', 80));
            Console.WriteLine($" {Name} | {Price}грн\\шт | {Quantity}шт ");
            Console.WriteLine(new String('-', 80));
            Console.ResetColor();
        }

    }
}
