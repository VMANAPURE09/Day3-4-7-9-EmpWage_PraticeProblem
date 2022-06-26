using System;

namespace EmployeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWageCalculation EmployeeWage = new EmployeeWageCalculation();
            EmployeeWage.Attendance("DMart", 20, 2, 10);
            EmployeeWage.Attendance("BigBazar", 10, 4, 20);
            EmployeeWage.Attendance("BigBascket", 15, 6, 22);

            Console.ReadKey();
        }
     
    }
}
