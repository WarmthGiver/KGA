using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("나눗셈을 진행할 첫 번째 수를 입력하여 주세요: ");

            string input = Console.ReadLine();

            int.TryParse(input, out int firstValue);

            Console.Write("두번째 나눌 수를 입력해주세요: ");

            input = Console.ReadLine();

            int.TryParse(input, out int secondValue);

            int quotient = firstValue / secondValue;

            int remain = firstValue % secondValue;

            Console.WriteLine($"{firstValue}와 {secondValue}의 나눗셈 결과, 몫은 {quotient} 나머지는 {remain}");
        }
    }
}
