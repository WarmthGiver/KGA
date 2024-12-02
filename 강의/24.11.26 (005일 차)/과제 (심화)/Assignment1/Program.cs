/*
이름: 이시온
날짜: 2024.11.26

### 심화 과제 1. 조건에 따른 무한 반복 기능

- 수업 내용 마지막에 있던 마을, 사냥터를 이동하는 프로그램은 문자열은 잘 걸러주고 재입력을 요구하지만 1, 2, 3이 아닌 숫자가 입력되면 재입력을 요구하는 것이 아닌 입력이 틀렸다며 바로 종료되는 문제가 있다.
- 숫자 1, 2, 3을 제외한 모든 입력에 대하여 재입력을 요구하도록 수정한다
 */
using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("숫자 입력: ");

                int.TryParse(Console.ReadLine(), out int toDetermine);

                Console.Clear();

                switch (toDetermine)
                {
                    case 1:

                        Console.WriteLine("마을로 이동하였습니다");

                        return;

                    case 2:

                        Console.WriteLine("사냥터로 이동하였습니다");

                        return;

                    case 3:

                        Console.WriteLine("상점으로 이동하였습니다");

                        return;

                    default:

                        Console.WriteLine("1,2,3 어느것도 아니에요\n");

                        break;
                }
            }
        }
    }
}