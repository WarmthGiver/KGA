using System;

namespace Assignment5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            WriteNumbersInRange(1, 10);
            Console.WriteLine();
        }

        private static void WriteNumbersInRange(int start, int end)
        {
            // 재귀 함수(Recursion Function)
            //

            Console.Write($"{start} ");

            if (start == end)
            {
                return;
            }

            WriteNumbersInRange(start + 1, end);
        }
    }
}