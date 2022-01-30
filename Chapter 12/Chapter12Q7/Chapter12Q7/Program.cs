using System;

namespace Chapter12Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                Console.WriteLine("Enter number here");
                int num = int.Parse(Console.ReadLine());

                double newNum = Math.Sqrt(num);
                if (newNum > 0)
                {
                    Console.WriteLine("Valid Number");
                    Console.WriteLine("Good bye!");
                }
                else
                {

                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid Number Input");
                Console.WriteLine("Good bye!");

            }
           
        }
    }
}
