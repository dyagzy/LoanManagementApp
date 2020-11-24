using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanTermCalculator();
        }

        static void LoanTermCalculator()
        {

            // Variable declarations
            double Rate = 0.0;
            double Factor = 0.0;
            decimal monthlyPay = 0.0M;
            Console.WriteLine("Welcome to Doshen Transatlantic Bank");
            Console.WriteLine("Your Gate way to Financial Freedom");
            Console.WriteLine("Please enter your loan amount in this format [XY.ZW]");
            decimal loan = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your annual interest rate for example 7.2% should be entred as 7.2");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the loan tenure or how long you want the loan in years [Whole Numbers ONLY!!!]");
            int time = 12 *  int.Parse(Console.ReadLine());

            // Formular for calculations

            Rate = rate / 1200;
            Factor = Math.Pow(1 + Rate, time);
            monthlyPay = loan * (decimal)(Rate * Factor / (-1 + Factor));

            //Output and string formatting

            Console.WriteLine("When you apply for a loan of : {0:c}", loan);
            Console.WriteLine("at an annual rate of  : {0:0.00%}", rate/100);
            Console.WriteLine("When you apply for a loan of : {0:c}", monthlyPay);
            Console.WriteLine("******End of Program******");
            Console.Read();

        }

    }
}
