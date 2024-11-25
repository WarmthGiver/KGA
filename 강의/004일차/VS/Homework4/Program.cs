using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫째 정수 입력");

            string input = Console.ReadLine();

            int.TryParse(input, out int firstValue);

            input = Console.ReadLine();

            int.TryParse(input, out int secondValue);

            input = Console.ReadLine();

            int.TryParse(input, out int thirdValue);

            int result = (firstValue + secondValue) * thirdValue;

            Console.WriteLine($"첫째수 더하기 둘째수에 셋째수를 곱한 값은 {result} 입니다");
        }
    }
}
