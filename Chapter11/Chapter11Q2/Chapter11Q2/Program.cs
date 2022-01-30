using System;

namespace Chapter11Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            for (int i = 0; i <= 10; i++)
            {
                int Numbers = rand.Next(100, 200);
                Console.WriteLine(Numbers);
            }
            
        }
    }
}
