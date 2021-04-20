using System;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Instantiating the objects
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            //setting property values
            dougDonut.Filling = "none";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.isSpecial = true;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "small";
            chrisDonut.isSpecial = false;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.isSpecial = true;

            Console.WriteLine(nickDonut.Filling);

        }
    }
}
