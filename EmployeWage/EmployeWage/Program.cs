using System;

namespace EmployeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC1 present or absent
            // UC2 Calculate Daily Wage
            // UC3 Part time Employee
            
            CheckEmployeePresentAbsent();
        }
        public static void CheckEmployeePresentAbsent()
        {
            Console.WriteLine("Welcome to Employee Pay Roll");
            int totalWorkingHour = 8;
            int partTimeHour = 4;
            int wagePerHour = 20;
            int dailyWage = 0;
            Random random = new Random();
            int num = random.Next(0, 3);
            if (num == 0)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
            }
            else if (num == 2)
            {
                Console.WriteLine("Employee is doing Parttime");
                dailyWage = partTimeHour * wagePerHour;
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Total Daily wage is: " + dailyWage);

        }
    }
}
