/*
이름: 이시온
날짜: 2024.11.26

## 과제 2. 다수의 입력을 받아 횟수만큼 반복하는 기능 제작

- 사용자로부터 정수 두 개를 입력 받고 입력한 값을 포함, 그 사이에 있는 모든 정수의 합을 구하는 프로그램. <br> 예를 들어 유저가 4와 7을 입력하였다면 4+5+6+7의 결과값인 22를 출력해야 한다
    - "두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요" 출력
    - 시작할 수 입력 받기
    - "끝 수를 입력해주세요" 출력
    - 마지막 수 입력 받기
    - 반복문을 통하여 시작부터 끝 수까지 합을 임의의 변수에 저장
    - 반복문이 끝난 후 "n1과 n2 사이 숫자의 합은 n3입니다" 출력
 */

using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요");

            int.TryParse(Console.ReadLine(), out int n1);

            Console.WriteLine("끝 수를 입력해주세요");

            int.TryParse(Console.ReadLine(), out int n2);

            int sum = 0;

            for (int i = n1; i <= n2; ++i)
            {
                sum += i;
            }

            Console.Clear();

            Console.WriteLine($"{n1}과 {n2} 사이 숫자의 합은 {sum}입니다");
        }
    }
}