using System;

namespace _03._Restaurant_Discount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = Math.Abs(int.Parse(Console.ReadLine()));
            string package = Console.ReadLine();

            double price = 0;
            string hall = null;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price += 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                price += 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Graet Hall";
                price += 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            switch (package)
            {
                case "Normal":
                    price += 500;
                    price *= 0.95;
                    break;
                case "Gold":
                    price += 750;
                    price *= 0.9;
                    break;
                case "Platinum":
                    price += 1000;
                    price *= 0.85;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {price / groupSize:f2}$");
        }
    }
}