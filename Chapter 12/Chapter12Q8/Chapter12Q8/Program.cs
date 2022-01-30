using System;

namespace Chapter12Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

           ReadNumbers();
        }


        static void ReadNumbers()
        {
            try
            {
                int count = 0;
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Enter your number here");
                    int num = int.Parse(Console.ReadLine());

                    count = +i;

                    
                    if (num != i || num>count )
                    {
                        
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("An invalid number has been entered");
            }
             
        }
    }
}
