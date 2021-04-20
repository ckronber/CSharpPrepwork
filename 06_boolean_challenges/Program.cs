using System;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze and Silver
            float value = 101/2.0f;
           // Console.WriteLine(value);
            if (value == 50.0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //Gold
            int randVal = 29;
            int userVal;
            do
            {
                Console.WriteLine("Pick a number between 1 and 100: ");
                userVal = Convert.ToInt32(Console.ReadLine());

                if (userVal == randVal)
                {
                    Console.WriteLine("Nice Job! You guessed correctly.");
                }
                else if (userVal > randVal)
                {
                    Console.WriteLine("Choose a lower number.");
                }
                else
                {
                    Console.WriteLine("Choose a higher number.");
                }
            } while (userVal != randVal);

            Console.ReadLine();

        }
    }
}
