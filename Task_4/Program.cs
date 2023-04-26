using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new String('=', 80));
            Console.WriteLine(" Програма для створення Інвойсу:");
            Console.WriteLine(new String('=', 80));


            Provider erc = new Provider("ERC", "+380971234632");
            Сustomer сustomer1 = new Сustomer("Artem", "Prydchenko", "380931536231");
            Product[] products =
            {
                new Product("Fone", 100, 3),
                new Product("Tyu", 120, 4),
                new Product("Hoi", 60, 12),
            };

            Invoice invoice = new Invoice(сustomer1, erc, products);

            bool resPDV = false;
            ConsoleKeyInfo buttonMenu;
            bool InbuttonMenuTrue = false;
            do
            {
                buttonMenu = UserButonMenu("Платник ПДВ: ", "Q - ТАК; E - НІ: ");
                InbuttonMenuTrue = buttonMenu.Key == ConsoleKey.Q || buttonMenu.Key == ConsoleKey.E;

                if (InbuttonMenuTrue)
                {
                    resPDV = (buttonMenu.Key == ConsoleKey.Q) ? true : false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ви вибрали неправельне меню спробуйте ще раз\n");
                    Console.ResetColor();
                }
            } while (!InbuttonMenuTrue);

            invoice.InPDV = resPDV;


            Console.Clear();
            invoice.ShowInvoiceInfo();

            Console.ReadKey();

        }

        public static ConsoleKeyInfo UserButonMenu(string infoOp, string infoBox)
        {
            Console.WriteLine(infoOp);
            Console.Write(infoBox);
            ConsoleKeyInfo buttonMenu = Console.ReadKey();
            Console.WriteLine();
            return buttonMenu;
        }
    }
}
