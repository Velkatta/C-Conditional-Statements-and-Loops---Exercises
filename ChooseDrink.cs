using System;

namespace _01._Choose_a_Drink
{
    class ChooseDrink
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string drink = null;

            if (profession == "Athlete")
            {
                drink = "Water";
            }
            else if (profession == "Businessman" || profession ==" businesswoman")
            {
                drink = "Coffee";
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }
            Console.WriteLine(drink);        
        }
    }
}