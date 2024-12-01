/*
이름: 이시온
날짜: 24.11.29

**심화 과제 2. 자릿수 합 디코더 제작**

- 인자값으로 1이상의 수를 입력받았을 때, 주어진 정수의 각 자리 수를 더한 결과를 정수형으로 반환하는 함수를 작성하세요. 예를 들어, 5611은 5+6+1+1 로 13을 반환하는 함수입니다.
*/
using System;

namespace Assignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage =
                "**심화 과제 2. 자릿수 합 디코더 제작**\n" +
                "\n-" +
                "인자값으로 1이상의 수를 입력받았을 때, 주어진 정수의 각 자리 수를 더한 결과를 정수형으로 반환하는 함수를 작성하세요.\n" +
                "예를 들어, 5611은 5+6+1+1 로 13을 반환하는 함수입니다.";

            Console.WriteLine();
            Console.Write(passage);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("정수 입력: ");
            int.TryParse(Console.ReadLine(), out var value);

            int result = AddDigits(value);

            Console.WriteLine();
            Console.Write($"각 자리 수의 합: {result}");
            Console.WriteLine();
        }

        private static int AddDigits(int value)
        {
            int sum = 0;

            while (value > 0)
            {
                sum += value % 10;
                value /= 10;
            }

            return sum;
        }
    }
}