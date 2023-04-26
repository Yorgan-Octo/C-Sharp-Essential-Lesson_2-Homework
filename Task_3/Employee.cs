using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Employee
    {
        private string name;
        private string lastName;
        private Profeshin profeshin;
        private int salary;

        private int experience;

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        public Employee(string name, string lastName, Profeshin profeshin)
        {
            this.name = name;
            this.lastName = lastName;
            this.profeshin = profeshin;

            //можно булоб такчамо зробити через властивысть але вирышив через конструктор
            salary = (profeshin == Profeshin.Тrainee) ? 400
                            : (profeshin == Profeshin.Accountant) ? 1000
                            : (profeshin == Profeshin.Manager) ? 1200
                            : (profeshin == Profeshin.Administrator) ? 1600 : 10;
        }

        public void ShowInfo()
        {

            Console.WriteLine(new String('=', 80));
            Console.WriteLine($"ФІО {name} {lastName}");
            Console.WriteLine($"Посада: {profeshin} | Досвід: {Experience} років");
            Console.WriteLine(new String('-', 80));
            Console.WriteLine($"Оклад: {SeniorityAllowance()}$ | Податковий збір: {TaxCollection()}$");
            Console.WriteLine(new String('=', 80));
        }

        private int SeniorityAllowance()
        {
            salary += (experience >= 0 && experience < 5) ? 50
                            : (experience >= 5 && experience < 10) ? 100
                            : (experience >= 10 && experience < 15) ? 150
                            : (experience >= 15 && experience < 20) ? 200 : 400;

            return salary;
        }

        private int TaxCollection()
        {
            int tax = salary * 20 / 100;
            return tax;
        }

    }
}
