using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {

        //цьго разу вирішив писати ці функції тут
        static string UserInString(string textMes)
        {
            Console.Write(textMes);
            string usIn = Console.ReadLine();
            return usIn;
        }

        static byte UserInByte(string textMes)
        {
            byte usIn;
            while (true)
            {
                try
                {
                    Console.Write(textMes);
                    usIn = byte.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    ShowError("Некоректні данні!");
                }
            }

            return usIn;
        }

        static void ShowError(string textError)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(textError);
            Console.ResetColor();
        }


        static void Main(string[] args)
        {

            Console.WriteLine(new String('=', 50));
            Console.WriteLine(" Анкета форма 517! Обязательная к заполнению!");
            Console.WriteLine(new String('=', 50));

            string login = UserInString("Введіть логін: ");
            string name = UserInString("Введіть Імя: ");
            string lastName = UserInString("Введіть Прізвище: ");


            byte age = UserInByte("Введіть Вік: ");


            //можна і через конструктор але це так для практики
            User user1 = new User(DateTime.Now)
            {
                Login = login,
                Name = name,
                LastName = lastName,
                Age = age

            };


            Console.WriteLine("\nНатисныть на будь яку кнопку щоп вивести дані про юзера!\n");
            Console.ReadKey();
            Console.Clear();

            user1.ShowInfoUser();

            Console.ReadKey();

        }
    }
}
