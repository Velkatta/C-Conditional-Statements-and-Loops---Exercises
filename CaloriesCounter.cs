using System;

namespace _08._Calories_Counter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int papper = 50;
            int totalCal = 0;

            for (int i = 0; i < number; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                switch (ingredients)
                {
                    case "cheese":
                        totalCal += cheese;
                        break;
                    case "tomato sauce":
                        totalCal += tomatoSauce;
                        break;
                    case "salami":
                        totalCal += salami;
                        break;
                    case "pepper":
                        totalCal += papper;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCal}");
        }
    }
}