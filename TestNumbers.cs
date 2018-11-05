using System;

namespace _12._Test_Numbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int k = 1; k <= m; k++)
                {
                    sum += i * k * 3;
                    count++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }                    
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");
            return;
        }
    }
}