using System;

namespace Chapter11Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isLeapYear = false;
            Console.WriteLine("Enter the year you want to check");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                isLeapYear = true;
                Console.WriteLine($"The year {year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{isLeapYear}, {year} is not a leap year");
            }


        }
    }
}
