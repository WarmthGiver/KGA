/*
이름: 이시온
날짜: 2024.11.25

과제 2. 두 수의 합 출력

- 두 실수를 유저로부터 한줄씩 입력받아, 마지막 줄엔 둘의 합을 출력해보아요
  - "첫 번째 실수를 입력하여 주세요"
  - 다음 줄에서 입력 받기
  - "두 번째 실수를 입력하여 주세요"
  - 다음 줄에서 두번째 수 입력 받기
  - "두 수의 합은 ??? 입니다" 형식으로 출력
*/

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