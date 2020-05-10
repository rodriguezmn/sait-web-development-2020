// Program Name:    Payroll Calculations - Major Assignment 1
//
// Author:          Marlon R.
//
// Date:            29-March-2020
//
// Description:     Solution that prepares a Pay Slip to be included in a cheque envelope
//                  for the employees of a small business.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ma_1_payroll_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName;            // will contain the Name of the employee
            double hoursWorked;             // will contain the number of Hours Worked by the employee
            double payRate;                 // will contain the Rate of Pay of the employee
            double deductionPercentage;     // will contain the % of Gross Pay that is deducted from gross pay
            double grossPay;                // will contain the Gross Pay value
            double deductionAmount;         // will contain the dollar amount of Deduction
            double netPay;                  // will contain the Net Pay amount


            // prompt the user for Name, Hours Worked, Hourly Wage and Deduction Percentage

            Console.Write("Enter the Employee Name: ");
            employeeName = Console.ReadLine();

            Console.Write("Enter the number of Hours Worked. <Decimal hours allowed>: ");
            hoursWorked = double.Parse(Console.ReadLine());

            Console.Write("Enter the Hourly Wage: ");
            payRate = double.Parse(Console.ReadLine());

            Console.Write("Enter Deduction Percentage. <Whole percentages only>: ");
            deductionPercentage = double.Parse(Console.ReadLine()) / 100;



            // calculate:
            //      employee Gross Pay
            //      dollar amount of Deductions -> Gross Pay * Deduction Percentage
            //      Net Pay -> Gross Pay - Deduction Amount

            grossPay = hoursWorked * payRate;

            deductionAmount = grossPay * deductionPercentage;

            netPay = grossPay - deductionAmount;



            // format and output results to console 
            // used the String.Format() method for creating the Pay Slip format

            Console.WriteLine("\n\n");
            Console.WriteLine(string.Format("{0,24}{1,-24}", "Name:", $" { employeeName}"));
            Console.WriteLine(string.Format("{0,24}{1,-24}\n", "Hours worked:", $" { hoursWorked}"));
            Console.WriteLine("{0,24}{1,15}", "Gross Pay:", $"{grossPay:C2}");
            Console.WriteLine("{0,24}{1,15}", "Deductions:", $"{ -1 * deductionAmount:C2}");
            Console.WriteLine("{0,24}{1,16}", "", "-----------");
            Console.WriteLine("{0,24}{1,15}\n\n", "Net pay:", $"{netPay:C2}");
        }
    }
}