/*
이름: 이시온
날짜: 24.11.29

**심화 과제 1. 복합조건을 가진 함수 제작**

- 인자값으로 정수형 하나가 주어지면, 숫자 1에서부터 인자값으로 전달받은 숫자 사이의 모든 자연수 중, 3의 배수이거나 5의 배수인 수들의 합을 구하여 정수형으로 반환하는 함수를 작성하세요
*/
using System;

namespace Assignment1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage =
                "**심화 과제 1. 복합조건을 가진 함수 제작**\n" +
                "\n-" +
                "인자값으로 정수형 하나가 주어지면, 숫자 1에서부터 인자값으로 전달받은 숫자 사이의 모든 자연수 중,\n" +
                "3의 배수이거나 5의 배수인 수들의 합을 구하여 정수형으로 반환하는 함수를 작성하세요";

            Console.WriteLine();
            Console.Write(passage);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("정수 입력: ");
            int.TryParse(Console.ReadLine(), out var max);
            
            int result = AddMultiplesOf3Or5InRange(max);

            Console.WriteLine();
            Console.Write($"3의 배수이거나 5의 배수인 수들의 합: {result}");
            Console.WriteLine();
        }

        private static int AddMultiplesOf3Or5InRange(int max)
        {
            int sum = 0;

            for (int i = 1; i <= max; ++i)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}