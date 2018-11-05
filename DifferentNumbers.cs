using System;

namespace _11._5_Different_Numbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first + 5 > second)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = first; i <=second - 4; i++)
            {
                for (int j = first + 1; j <= second - 3; j++)
                {
                    for (int k = first + 2; k <= second - 2; k++)
                    {
                        for (int m = first + 3; m <= second - 1; m++)
                        {
                            for (int s = first + 4; s <= second; s++)
                            {
                                if (i < j && j < k && k < m && m < s)
                                {
                                    Console.WriteLine($"{i} {j} {k} {m} {s}");
                                }
                            }
                        }
                    }
                }
            }


        }
    }
}
