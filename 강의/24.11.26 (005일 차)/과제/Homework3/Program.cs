/*
이름: 이시온
날짜: 2024.11.26

## 과제 3. 구구단 기능 제작

- 유저로부터 정수 하나를 입력받고, 입력받은 수의 구구단을 출력하는 프로그램 제작. 예를 들어 3을 입력 받으면 3단에 대한 구구단 출력. 단, 유저가 입력한 수가 9를 초과하거나 숫자가 아닌 것을 입력하면 정상적인 입력이 아닐 경우,
제대로 된 입력이 나올때까지 무한 반복하는 예외처리도 있어야 한다
    - "출력하고자 하는 구구단을 입력해주시길 바랍니다" 출력
    - 유저로부터 1~9까지의 숫자를 입력받음
    - "3x1 = 3, 3x2 =6, 3x3 = 9" 등등 해당 구구단 출력
    - 만약 1~9가 아닌 숫자 혹은 문자열이 들어오면 다시 입력하라고 반복시키기
 */

using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("출력하고자 하는 구구단을 입력해주시길 바랍니다");

            while (true)
            {
                int.TryParse(Console.ReadLine(), out var n);

                if (1 <= n && n <= 9)
                {
                    Console.Clear();

                    for (int i = 1; i <= 9; ++i)
                    {
                        Console.WriteLine($"{n}x{i} = {n * i}");
                    }

                    break;
                }
            }
        }
    }
}