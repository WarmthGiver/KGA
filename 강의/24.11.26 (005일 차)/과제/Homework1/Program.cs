/*
이름: 이시온
날짜: 2024.11.26

## 과제 1. 입력받은 횟수만큼 반복하는 기능 제작

-사용자로부터 정수를 하나 입력받고, 그 수만큼 반복하는 문구 출력하기
    - "몇회 반복하시겠습니까?" 출력
    - 입력을 받기
    - "n 회 반복중입니다"을 반복적으로 출력. n에는 현재 반복회차 표시하기
 */

using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇회 반복하시겠습니까?");

            int.TryParse(Console.ReadLine(), out int loopCount);

            for (int n = 1; n <= loopCount; ++n)
            {
                Console.WriteLine($"{n}회 반복중입니다");
            }
        }
    }
}