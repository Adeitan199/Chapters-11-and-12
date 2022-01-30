using System;

namespace Chapter11Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of side a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of side a");
            int b = int.Parse(Console.ReadLine());

            double c = Math.Sqrt(a) + Math.Sqrt(b);

            Console.WriteLine(c);
        }
    }
}
