/*
이름: 이시온
날짜: 2024.11.25

과제 3. 두 정수의 몫과 나머지 출력

- 두 정수를 유저로부터 입력 받고, 몫과 나머지를 출력해보자
  - "나눗셈을 진행할 첫 번째 수를 입력하여 주세요: " 출력
  - 같은 줄에서 입력 받기
  - 그 다음줄로 와서 "두번째 나눌 수를 입력해주세요: " 출력
  - 위 출력과 같은 줄에서 입력을 받기
  - 그 다음 줄에서 "(첫째수)와 (둘째수)의 나눗셈 결과, 몫은 (몫) 나머지는 (나머지)" 출력
*/

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