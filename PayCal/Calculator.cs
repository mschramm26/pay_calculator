using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCal
{
    class Calculator
    {
        double wage;
        double hours;
        double result;
        public double CalculatePay()
        {
            Console.WriteLine("Please enter your hourly wage.");
            string userInputWage = Console.ReadLine();
            wage = double.Parse(userInputWage);
            Console.WriteLine("Please enter the number of hours you worked this week.");
            string userInputHours = Console.ReadLine();
            hours = double.Parse(userInputHours);

            if (hours > 40)
            {
                double overtimeHours = hours - 40;
                result = (wage * 40) + (overtimeHours * (wage * 1.5));
            }

            else
            {
                result = wage * hours;
            }

            Console.WriteLine("Your weekly pay is: $" + result);
            Console.Read();
            return result;
        }
    }
}

