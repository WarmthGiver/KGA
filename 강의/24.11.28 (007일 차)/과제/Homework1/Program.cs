/*
이름: 이시온
날짜: 24.11.28

**과제1**

플레이어에게 4개의 스킬이 있고, 각각 쿨타임이 존재. 매 턴마다 쿨타임이 줄어드는 기능 제작

엔터 한번 입력 받을때마다 혹은 특정 키 한번 입력 할때마다 한 턴이 흐름

1. 길이가 4인 int 배열 skillCooldowns를 만들기
2. 초기값은 [5, 3, 10, 7]
3. 매 턴마다 배열의 모든 값을 1씩 줄임
4. 쿨타임이 0 이하가 되면 "스킬 X 사용 가능!"을 출력하고, 값을 그대로 0으로 유지
5. 매 턴마다 배열의 상태를 출력

힌트:

반복문을 사용해서 배열 값을 수정하고 출력
조건문으로 값이 0 이하인지 확인
*/

using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] skillCooldowns =
            {
                5, 3, 10, 7
            };

            while (true)
            {
                for (int i = 0; i < 4; ++i)
                {
                    Console.Write($"{skillCooldowns[i]}\t");
                }

                Console.WriteLine();

                Console.ReadKey(true);

                for (int i = 0; i < 4; ++i)
                {
                    if (skillCooldowns[i] > 0)
                    {
                        if (--skillCooldowns[i] == 0)
                        {
                            Console.WriteLine();

                            Console.WriteLine($"스킬 {i + 1} 사용 가능!");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}