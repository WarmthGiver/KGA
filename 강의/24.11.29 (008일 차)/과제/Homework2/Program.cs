/*
이름: 이시온
날짜: 24.11.29

**과제 2. 다수의 인자값 및 반환형을 가진 함수 구현**

- 5개의 float형을 인자로 받아, 그 중 가장 큰 두 수의 합을 실수형으로 반환하는 함수
*/
using System;

namespace Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage =
                "**과제 2. 다수의 인자값 및 반환형을 가진 함수 구현**\n" +
                "\n" +
                "- 5개의 float형을 인자로 받아, 그 중 가장 큰 두 수의 합을 실수형으로 반환하는 함수";

            Console.WriteLine();
            Console.Write(passage);
            Console.WriteLine();

            const int count = 5;

            float[] values = new float[count];

            for (int i = 0; i < count; ++i)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}번째 실수 입력: ");
                float.TryParse(Console.ReadLine(), out values[i]);
            }

            float result = AddTwoMaxValues(values);

            Console.WriteLine();
            Console.Write($"가장 큰 두 수의 합: {result}");
            Console.WriteLine();
        }

        private static float AddTwoMaxValues(float[] values)
        {
            float max1 = values[0];
            float max2 = values[1];

            if (max1 < max2)
            {
                max1 = values[1];
                max2 = values[0];
            }

            for (int i = 2; i < values.Length; ++i)
            {
                if (values[i] > max1)
                {
                    max2 = max1;
                    max1 = values[i];
                }
                else if (values[i] > max2)
                {
                    max2 = values[i];
                }
            }

            return max1 + max2;
        }
    }
}