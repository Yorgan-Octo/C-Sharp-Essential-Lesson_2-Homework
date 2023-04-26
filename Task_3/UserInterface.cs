using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class UserInterface
    {

        public void ShowTitle()
        {
            Console.WriteLine(new String('=', 80));
            Console.WriteLine("Прогрма розрахунку заробітньох плати так податку;");
            Console.WriteLine(new String('=', 80));

        }

        public (string, string) FullNameIn()
        {
            Console.Write("Введіть Імя: ");
            string name = Console.ReadLine();

            Console.Clear();
            ShowTitle();

            Console.Write("Введіть Прізвище: ");
            string lastName = Console.ReadLine();

            return (name, lastName);
        }


        public Profeshin ProfesionUserIn()
        {

            Profeshin[] days = (Profeshin[])Enum.GetValues(typeof(Profeshin));


            Profeshin profeshin = default;
            while (true)
            {
                try
                {
                    Console.WriteLine("Виберіть посаду 1 - Тrainee, 2 - Accountant, 3 - Manager, 4 - Administrator");
                    Console.Write("Посада: ");
                    int name = int.Parse(Console.ReadLine());
                    profeshin = days[name - 1];
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    ShowTitle();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка ввода данних спробуйте ще раз!");
                    Console.ResetColor();
                }
            }

            return profeshin;
        }

        public int ExperienceUserIn()
        {

            int experience = default;
            while (true)
            {
                try
                {
                    Console.Write("Вислуга років: ");
                    experience = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    ShowTitle();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка ввода данних спробуйте ще раз!");
                    Console.ResetColor();
                }
            }

            return experience;
        }




    }
}
