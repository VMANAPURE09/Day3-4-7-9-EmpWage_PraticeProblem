using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    internal class EmployeeWage
    {
        public static void CheckEmployeePresentAbsent()
        {
            Console.WriteLine("Welcome to Employee Pay Roll");
            int Emp_Rate_Per_Hour = 20;
            int Emphrs = 0;
            int Empwage = 0;
            int total_Emp_hrs = 0;
            int total_working_days = 0;

            int Total_working_hrs = 100;
            int Total_working_days = 20;
            int Totalwage = 0;
            while (total_Emp_hrs < Total_working_hrs && total_working_days < Total_working_days)
            {
                total_working_days++;
                Random random = new Random();
                int employeecheck = random.Next(2);

                if (employeecheck == 1)
                {
                    Console.WriteLine("Employee is Present");
                    Emphrs = 8;
                }
                else
                {
                    Console.WriteLine("Emplyee is Absent");
                    Emphrs = 0;
                }



                total_Emp_hrs = total_Emp_hrs + Emphrs;

                Empwage = total_Emp_hrs * Emp_Rate_Per_Hour;



                Console.WriteLine("Total Employee Wage :" + Empwage);
            }
        }
    }
}
