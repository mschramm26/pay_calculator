﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pay Calculator";
            Calculator calculator = new Calculator();
            calculator.CalculatePay();
        }
    }
}
