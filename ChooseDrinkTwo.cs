using System;

namespace _02._Choose_a_Drink_Two
{
    class ChooseDrinkTwo
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;
            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;

            if (profession == "Athlete")
            {
                price = quantity * water;
            }
            else if (profession == "Businessman" || profession =="Businesswoman")
            {
                price = quantity * coffee;
            }
            else if (profession == "SoftUni Student")
            {
                price = quantity * beer;
            }
            else
            {
                price = quantity * tea; 
            }
            Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
        }
    }
}