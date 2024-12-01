/*
이름: 이시온
날짜: 24.11.28

**과제2**

4x4 16개의  정수를 담을 수 있는 2차원 배열을 만든 후,
반복문을 이용하여 3의 배수들로 채워 넣는다.
그 후 2행3열 요소와 3행 2열 요소를 바꾼 후 출력하여보자

1. int형 2차원 배열을 선언
2. 반복문을 통하여 순서대로 3의 배수들로 채워넣음
3. 2행3열 요소와 3행 2열 요소를 바꾼다
4. 4x4의 형태로 들어있는 숫자들을 출력
*/

using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int row = 4, col = 4;

            int[,] integerMatrix = new int[row, col];

            int current = 3;

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    integerMatrix[i, j] = current;

                    current += 3;
                }
            }

            int temp = integerMatrix[1, 2];

            integerMatrix[1, 2] = integerMatrix[2, 1];

            integerMatrix[2, 1] = temp;

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    Console.Write($"{integerMatrix[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}