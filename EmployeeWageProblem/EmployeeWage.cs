﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, HALF_DAY_HR = 4, IS_PRESENT = 0, IS_FULL_TIME = 1, MONTH_WORK_DAY = 20;
        Random random = new Random();
        public void Attendence()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void EmpWage()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = FULL_DAY_HR;
            else
                empHrs = 0;
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
        }
        public void PartTime()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                empHrs = HALF_DAY_HR;
            else
                empHrs = 0;
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily Emp Wage Half Day :" + dailyEmpWage);
        }
        public void switchCase()
        {
            int dailyEmpWage = 0;
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {

                case 0:
                    dailyEmpWage = WAGE_PER_HR * FULL_DAY_HR;
                    Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
                    break;
                case 1:
                    dailyEmpWage = WAGE_PER_HR * HALF_DAY_HR;
                    Console.WriteLine("Daily Emp Wage Half Day :" + dailyEmpWage);
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }

        }
        public void MonthlyWage()
        {
            int FullWage = 0, HalfWage = 0;
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
            {
                FullWage = MONTH_WORK_DAY * WAGE_PER_HR * FULL_DAY_HR;
                HalfWage = MONTH_WORK_DAY * WAGE_PER_HR * HALF_DAY_HR;
                Console.WriteLine("Monthly Employee Full Day :" + FullWage);
                Console.WriteLine("Monthly Employee Half Day :" + HalfWage);

            }
            else
            {
                Console.WriteLine("Monthly Employee is Absent");
            }


        }
        public void TotalMonthlyWages()
        {
            int day = 0, hours = 0, DailyEmpWage = 0, EmpWage = 0;
            while (day < 20 & hours < 100)
            {
                day++;
                hours += 8;

            }
            EmpWage = day * hours;
            DailyEmpWage = WAGE_PER_HR * EmpWage;
            Console.WriteLine("Employee Monthly Wage :" + DailyEmpWage);

        }
    }
}