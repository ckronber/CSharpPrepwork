using System;

namespace _05_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            // Concatenation

            string myName;
            string yourName = "Bob";
            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);

            //result: The cars we sell are BMW, Lexus, and Mercedes.


            // Composite Formatting

            string firstName = "Jenn";
            string lastName = "Williams";

            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            //result: Her name is Jenn Williams.

            firstName = "Robin";
            lastName = "Holler";

            // String Interpolation
                        
                            //1                 //2
            Console.WriteLine($"Her name is {firstName} {lastName}.");

            //result: Her name is Robin Holler.
            Console.ReadLine();
        }
    }
}
