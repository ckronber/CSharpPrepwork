using System;

namespace _09_Loops_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            for (int i = 500; i < 526; i++)
                Console.WriteLine(i);

            //Silver
            for (int i = 1; i < 101; i++)
                Console.WriteLine(i);

            //Gold
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
             }
        }

    }
}
