using System;

namespace _06._Interval_of_Numbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            //for (int i = Math.Min(firstNumber, secondNumber); i <= Math.Max(firstNumber, secondNumber); i++)
            //{
            //    Console.WriteLine(i);
            //}

            int bigger = Math.Max(firstNumber, secondNumber);
            int smaller = Math.Min(firstNumber, secondNumber);
            
            while (smaller <= bigger)
            {
                Console.WriteLine(smaller);
                smaller++;
            }
        }
    }
}