using System;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bronze
            int val1 = 938, val2;
            string name1 = "Arthur", name2;
            bool b1 = true, b2;
            float fl1 = 1.24378f, fl2;
            double db1 = 1.3828478, db2;
            decimal dc1 = 32.445m, dc2;
            Console.WriteLine(val1);
            Console.WriteLine(b1);
            Console.WriteLine(db1);

            //Silver
            name2 = "King of the Britains";
            string fullName = name1 + ", " + name2;
            Console.WriteLine(fullName);

            //Gold
            int year = 1987;
            string yr = year.ToString();

            Console.WriteLine(yr);

            Console.ReadLine();
        }
    }
}
