/*
이름: 이시온
날짜: 24.11.29

**과제 3. 특정 조건을 포함한 함수 제작**

- 2개의 정수를 입력 받고, 두 수의 차이가 100 미만일 경우 참, 아니면 거짓 반환하는 함수
*/
using System;

namespace Homework3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage =
                "**과제 3. 특정 조건을 포함한 함수 제작**\n" +
                "\n" +
                "- 2개의 정수를 입력 받고, 두 수의 차이가 100 미만일 경우 참, 아니면 거짓 반환하는 함수";

            Console.WriteLine();
            Console.Write(passage);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("첫 번째 정수 입력: ");
            int.TryParse(Console.ReadLine(), out var number1);
            
            Console.WriteLine();
            Console.Write("두 번째 정수 입력: ");
            int.TryParse(Console.ReadLine(), out var number2);

            bool result = IsBetweenLess100(number1, number2);

            Console.WriteLine();
            Console.Write($"두 수의 차이가 100 미만인가?: {result}");
            Console.WriteLine();
        }

        private static bool IsBetweenLess100(int value1, int value2)
        {
            if (value1 > value2)
            {
                return value1 - value2 < 100;
            }
            return value2 - value1 < 100;
        }
    }
}