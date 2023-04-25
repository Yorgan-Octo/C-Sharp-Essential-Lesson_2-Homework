using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task_2
{
    public class UserInterface
    {

        public void ShowTitle(string textShow)
        {
            Console.Clear();
            Console.WriteLine(new String('=', 80));
            Console.WriteLine(textShow);
            Console.WriteLine(new String('=', 80));
        }

        public double UserInSum()
        {
            double userSum = default;

            bool inWhile = true;
            while (inWhile)
            {
                try
                {
                    Console.Write("Введите суму для конвертации: ");
                    userSum = double.Parse(Console.ReadLine());

                    if (userSum <= 0)
                    {
                        ShowErrow("Ви не можете конвертувати 0 або відемну суму! Спробуйте ще раз!\n");
                    }
                    else
                    {
                        inWhile = false;
                    }
                }
                catch (Exception)
                {

                    ShowErrow("Невірні данні! Спробуйте ще раз!\n");
                }


            }

            return userSum;
        }

        public ConsoleKeyInfo UserСhooseCourse(string infoOp, string infoBox)
        {
            Console.WriteLine(infoOp);
            Console.Write(infoBox);
            ConsoleKeyInfo buttonMenu = Console.ReadKey();
            Console.WriteLine();
            return buttonMenu;
        }

        public void ShowErrow(string textError)
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(textError);
            Console.ForegroundColor = color;

        }

    }
}
