/*
이름: 이시온
날짜: 24.11.29

**과제 1. 다수의 인자값 요구 함수 구현**

- 4개의 정수를 인자로 받아 가장 큰 수를 출력하는 함수 제작
*/
using System;

namespace Homework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage =
                "**과제 1. 다수의 인자값 요구 함수 구현**\n" +
                "\n" +
                "- 4개의 정수를 인자로 받아 가장 큰 수를 출력하는 함수 제작";

            Console.WriteLine();
            Console.Write(passage);
            Console.WriteLine();

            const int count = 4;

            int[] values = new int[count];

            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}번째 정수 입력: ");
                int.TryParse(Console.ReadLine(), out values[i]);
            }

            Console.WriteLine();
            WriteMaxValue(values);
            Console.WriteLine();
        }

        private static void WriteMaxValue(int[] values)
        {
            int max = values[0];

            for (int i = values.Length - 1; i >= 1; --i)
            {
                if (max < values[i])
                {
                    max = values[i];
                }
            }

            Console.Write($"가장 큰 수: {max}");
        }
    }
}