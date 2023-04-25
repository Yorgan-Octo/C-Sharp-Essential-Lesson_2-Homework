using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(38, 23, 45);
            UserInterface userInterface = new UserInterface();

            while (true)
            {
                userInterface.ShowTitle("Програма конвертації Валют v0.23a");

                double userSum = userInterface.UserInSum();

                userInterface.ShowTitle("Програма конвертації Валют v0.23a");


                //тут перевірка на null
                string flagCourse = default;
                ConsoleKeyInfo buttonMenu;
                do
                {
                    buttonMenu = userInterface.UserСhooseCourse("Выберіть валюту: ", "| Q - USD | W - EUR | E - PLN |");

                    flagCourse = (buttonMenu.Key == ConsoleKey.Q) ? "USD" :
                        (buttonMenu.Key == ConsoleKey.W) ? "EUR" :
                        (buttonMenu.Key == ConsoleKey.E) ? "PLN" : null;

                    if (flagCourse == null)
                    {
                        userInterface.ShowErrow("Ви вибрали неправельне меню спробуйте ще раз\n");
                    }

                } while (flagCourse == null);


                userInterface.ShowTitle("Програма конвертації Валют v0.23a");

                //тут перевірка чи вірний вибрали пунк меню
                double sumConvert = default;
                bool InbuttonMenuTrue = false;
                do
                {
                    buttonMenu = userInterface.UserСhooseCourse("Виберіть тип конвертації: ", "Q - в валюту; E - із валюти!: ");
                    InbuttonMenuTrue = buttonMenu.Key == ConsoleKey.Q || buttonMenu.Key == ConsoleKey.E;

                    if (InbuttonMenuTrue)
                    {
                        sumConvert = (buttonMenu.Key == ConsoleKey.Q) ?
                        converter.InCourense(userSum, flagCourse) :
                        converter.OutCourense(userSum, flagCourse);
                    }
                    else
                    {
                        userInterface.ShowErrow("Ви вибрали неправельне меню спробуйте ще раз\n");

                    }
                } while (!InbuttonMenuTrue);


                userInterface.ShowTitle($"Результат конвертації: {sumConvert}грн");


                Console.ReadKey();
            }

        }

    }
}
