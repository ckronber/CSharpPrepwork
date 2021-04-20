using System;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop
            //1
            int number = 0;
            //2
            while(number <= 100)
            {
                //3
                Console.WriteLine(number);
                number += 5;
                //4
            }
            //5
            Console.ReadLine();

            //for loop
            number = 100;

            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
