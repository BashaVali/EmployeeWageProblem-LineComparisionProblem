using EmployeeWageProblem;
using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee wage statement");

            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Attendence();
            employeeWage.EmpWage();
            employeeWage.PartTime();
            employeeWage.switchCase();
            employeeWage.MonthlyWage();
            employeeWage.TotalMonthlyWages();
        }
    }
}