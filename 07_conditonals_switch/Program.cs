using System;

namespace _07_conditonals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            //2
            switch(inputName)
            {
                //3
                case "fred": //Same as checking: if (inputName == "fred")
                    Console.WriteLine("Hey Fred, let's go golfing.");
                    //4
                    break;
                case "karl": //Same as checking: if (inputName == "fred")
                    Console.WriteLine("Let's hang.");
                    break;
                case "john": //Same as checking: if (inputName == "john")
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default: //Same as: else
                    Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
                    break;
            }
            //5
            Console.ReadLine();
        }
    }
}
