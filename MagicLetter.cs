using System;

namespace _14._Magic_Letter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char k = first; k <= second; k++)
                {
                    for (char j = first; j <= second; j++)
                    {
                        if (i != third && k != third && j != third)
                        {
                            Console.Write($"{i}{k}{j} ");
                        }
                    }
                }
            }
        }
    }
}