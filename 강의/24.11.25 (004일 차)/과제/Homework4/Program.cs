/*
이름: 이시온
날짜: 2024.11.25

과제 4. 입력된 세 정수의 합 및 곱 출력

- 세 정수를 유저로부터 입력 받고, 앞 두개 숫자를 더하고 세번째 수는 곱하는 프로그램을
작성하되, **“첫째수 더하기 둘째수에 셋째수를 곱한 값은 X 입니다”** 라고 나오는 프로그램 제작.
  - "첫째 정수 입력" 출력
  - 같은 줄 혹은 다음 줄에 입력 받기
  - "둘째 정수 입력" 출력
  - 같은 줄 혹은 다음 줄에 입력 받기
  - "셋째 정수 입력" 출력
  - 같은 줄 혹은 다음 줄에 입력 받기
  - “첫째수 더하기 둘째수에 셋째수를 곱한 값은 (결과값) 입니다” 출력
  
  ※추가 설명: 첫째수와 둘째수를 먼저 더한 결과에 셋째수를 곱합니다
*/

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