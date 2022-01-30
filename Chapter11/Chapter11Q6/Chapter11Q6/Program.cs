using System;

namespace Chapter11Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of first side");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of first side");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of first side");
            int c = int.Parse(Console.ReadLine());

            //Sub Question 1
            double p = a + b + c / 2;

            double Q = p*((p - a) * (p - b) * (p - c));

            double Sides = Math.Sqrt(Q);
            Console.WriteLine(Sides);

            //Sub Question 2


            //Sub Question2
            double angleOfTwoSides = a * b * Math.Sin(c) / 2;

            Console.WriteLine(angleOfTwoSides);





        }
    }
}
