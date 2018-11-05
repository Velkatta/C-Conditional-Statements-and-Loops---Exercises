using System;

namespace _04._Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nigthsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;
                    if (nigthsCount > 7)
                    {
                        priceStudio *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;
                    if (nigthsCount > 14)
                    {
                        priceDouble *= 0.90;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;
                    if (nigthsCount > 14)
                    {
                        priceSuite *= 0.85;
                    }
                    break;
                default:
                    break;
            }

            if ((month == "September" || month == "October") && (nigthsCount > 7))
            {
                priceStudio *= (1 - (1.0 / nigthsCount));
            }
            Console.WriteLine($"Studio: {nigthsCount* priceStudio:f2} lv.");
            Console.WriteLine($"Double: {nigthsCount * priceDouble:f2} lv.");
            Console.WriteLine($"Suite: {nigthsCount * priceSuite:f2} lv.");

        }
    }
}
