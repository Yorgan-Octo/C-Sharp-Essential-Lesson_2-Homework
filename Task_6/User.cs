using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class User
    {
        private readonly DateTime dateOfQuestionnaire;

        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }


        public User(DateTime dateQuestionnaire)
        {
            this.dateOfQuestionnaire = dateQuestionnaire;
        }


        public void ShowInfoUser()
        {
            Console.WriteLine(new String('=',50));
            Console.WriteLine($" Логін користувача: {Login}");
            Console.WriteLine($" Імя користувача: {Name}");
            Console.WriteLine($" Прізвище користувача: {LastName}");
            Console.WriteLine($" Вік користувача: {Age}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($" Дата створення: {dateOfQuestionnaire}");
            Console.WriteLine(new String('=', 50));
        }


    }
}
