using System;

namespace _13._Game_of_Numbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            int count = 0;

            for (int i = m; i >= n; i--)
            {
                for (int k = m; k >= n; k--)
                {
                    count++;
                    if (i + k == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {k} = {magicNum}");
                        return;
                    }                  
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNum}");
        }
    }
}