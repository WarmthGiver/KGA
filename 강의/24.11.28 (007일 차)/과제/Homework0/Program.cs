/*
이름: 이시온
날짜: 24.11.28

**과제0**

4개의 정수를 담을 수 있는 배열을 하나 생성 후,
사용자에게 순서대로 값 입력 받아 순서대로 배열에 담기.
해당 문을 포이치로 출력하기

1. int 4개를 담을 배열을 선언
2. "1번 요소를 입력하여주십시오" 출력 후 입력받기
3. 나머지 번호도 마찬가지로 입력
4. "입력된 요소는 다음과 같습니다" 다음 줄에 입력된 값들 4개 출력
*/

using System;

namespace Homework0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int elementsCount = 4;

            int[] elements = new int[elementsCount];

            for (int i = 0; i < elementsCount; ++i)
            {
                Console.Write($"{i + 1}번 요소를 입력하여주십시오: ");

                int.TryParse(Console.ReadLine(), out elements[i]);

                Console.WriteLine();
            }

            Console.WriteLine("입력된 요소는 다음과 같습니다.");

            Console.WriteLine();

            foreach (int number in elements)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}