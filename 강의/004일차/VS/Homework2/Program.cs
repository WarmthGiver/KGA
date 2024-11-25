using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 실수를 입력하여 주세요");

            string input = Console.ReadLine();

            float.TryParse(input, out float firstValue);

            Console.WriteLine("두 번째 실수를 입력하여 주세요");

            input = Console.ReadLine();

            float.TryParse(input, out float secondValue);

            Console.WriteLine($"두 수의 합은 {firstValue + secondValue}입니다");
        }
    }
}