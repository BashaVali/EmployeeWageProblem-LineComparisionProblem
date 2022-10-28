using System;
namespace LineComparison
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Problem Statement");
            CalculateLength Calculate = new CalculateLength(1, 2, 3, 4);
            Calculate.Calculate();
        }
    }
}