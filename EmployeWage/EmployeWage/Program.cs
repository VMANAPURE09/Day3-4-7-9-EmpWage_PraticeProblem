using System;

namespace EmployeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC1 present or absent
            // UC2 Calculate Daily Wage
            CheckEmployeePresentAbsent();
        }
        public static void CheckEmployeePresentAbsent()
        {
            Console.WriteLine("Welcome to Employee Pay Roll");
            int totalWorkingHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0;
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Total Daily wage is: " + dailyWage);

        }
    }
}
