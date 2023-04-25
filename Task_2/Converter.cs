using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Converter
    {

        private double courseUSD;
        private double courseEUR;
        private double coursePLN;

        public Converter(double usd, double eur, double pln)
        {
            courseUSD = usd;
            courseEUR = eur;
            coursePLN = pln;
        }
        public void ShowAllCourse()
        {
            Console.WriteLine($"| USD: {courseUSD}грн | EUR: {courseEUR}грн | PLN: {coursePLN}грн |");
        }

        public double InCourense(double suma, string flagCourse)
        {
            double res = (flagCourse == "USD") ? suma / courseUSD : 
                (flagCourse == "EUR") ? suma / courseEUR : suma / coursePLN;
            return Math.Round(res,2);
        }
        public double OutCourense(double suma, string flagCourse)
        {
            double res = (flagCourse == "USD") ? suma * courseUSD :
                (flagCourse == "EUR") ? suma * courseEUR : suma * coursePLN;
            return Math.Round(res, 2);
        }

    }
}
