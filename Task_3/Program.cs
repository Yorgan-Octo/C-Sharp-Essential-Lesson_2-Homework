using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    enum Profeshin
    {
        Тrainee,
        Accountant,
        Manager,
        Administrator,
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            UserInterface userInterface = new UserInterface();


            userInterface.ShowTitle();

            var fullName = userInterface.FullNameIn();

            Console.Clear();
            userInterface.ShowTitle();
            Profeshin profeshin = userInterface.ProfesionUserIn();

            Console.Clear();
            userInterface.ShowTitle();
            int experience = userInterface.ExperienceUserIn();


            Employee employee = new Employee(fullName.Item1, fullName.Item2, profeshin)
            {
                Experience = experience,
            };


            Console.Clear();
            userInterface.ShowTitle();
            employee.ShowInfo();

            Console.ReadKey();
        }
    }
}
