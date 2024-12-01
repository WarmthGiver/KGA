/*
이름: 이시온
날짜: 24.11.28

**심화 과제 2**

과제1의 확장입니다. 플레이어에게 4개의 스킬이 있고, 각각의 스킬명이 존재합니다. 초기값은 다음과 같습니다. 변수를 쓰셔도, 배열을 쓰셔도 상관 없습니다

| Q스킬 | 5 |
| --- | --- |
| W스킬 | 3 |
| E스킬 | 10 |
| R스킬 | 7 |

콘솔을 킨 첫 화면에서 일단 모든 스킬과 턴을 보여줍니다.

그 아래에 유저에게 선택권을 줍니다.

1. 턴을 넘길지,
2. 스킬을 사용할 지 두 선택지를 줍니다.
https://img.notionusercontent.com/s3/prod-files-secure%2Fecbfc15b-d9e9-421e-911d-a5bceae47cb4%2F2126afa2-36eb-484d-bbe7-85453bf40f0f%2Fimage.png/size/w=1360?exp=1733148816&sig=nwXgNjxvcuT2EpYYLK29iMdpeHiXYdf9f1cvyY_P1Mk

1. 스킬을 선택하였다면, 어느 스킬을 사용할 지 입력받고 만약 그 스킬의 쿨타임이 0이면 다시 쿨타임 초기 숫자로 원복(Q는 5, W는3, E는 10, R은 7)
    
    
    쿨타임이 돌아오지 않은 것을 선택 시, 쿨타임이 돌아오지 않았다는 메시지 출력
    
2. 턴 넘김을 사용 시, 모든 스킬 쿨타임 1 감소. 만약 쿨타임 0이고 스킬을 사용하지 않는다면 0으로 유지. 만약 쿨타임이 0이라면 0을 출력하는 것이 아닌, “스킬준비완료” 를 출력합니다
3. 원하는 대로 커스터마이징 해도 괜찮습니다

아래는 예시입니다. 형태가 똑같을 필요는 없습니다. 더 이쁘게 만드셔도 됩니당
https://img.notionusercontent.com/s3/prod-files-secure%2Fecbfc15b-d9e9-421e-911d-a5bceae47cb4%2F0ef6d227-344a-4950-8fad-d25dbc4b4cfe%2Fimage.png/size/w=1360?exp=1733148818&sig=WKu5Ek0nqdbmOZSGtmYn9EI6IhAD7Nj7sWtkUis_Ius

숫자 0을 입력받을때까지 이를 무한으로 반복합니다

https://img.notionusercontent.com/s3/prod-files-secure%2Fecbfc15b-d9e9-421e-911d-a5bceae47cb4%2F36ed89ae-40a1-4dac-8a25-1729ed4ddd44%2Fimage.png/size/w=1360?exp=1733148928&sig=QUOi_HodYXdFx3OYHZmBJowfUWCbM0jiz9U39atU6N0
*/
using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] skillKeys =
            {
                "Q", "W", "E", "R"
            };

            int[] skillCooldowns =
            {
                5, 3, 10, 7
            };

            int[] currentSkillCooldowns =
            {
                5, 3, 10, 7
            };

            ConsoleKey menuKeyNumber = ConsoleKey.None;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("사용 가능한 스킬은 다음과 같습니다.");

                Console.WriteLine("--------------------");

                for (int i = 0; i < 4; ++i)
                {
                    Console.Write($"{skillKeys[i]}스킬: ");

                    if (currentSkillCooldowns[i] == 0)
                    {
                        Console.WriteLine("스킬 준비 완료");
                    }
                    else
                    {
                        Console.WriteLine(currentSkillCooldowns[i]);
                    }
                }

                Console.WriteLine("--------------------");

                Console.WriteLine("액션을 선택해주세요.");

                Console.WriteLine("--------------------");

                Console.WriteLine("0. 종료");

                Console.WriteLine("1. 턴 넘김");

                Console.WriteLine("2. 스킬 사용");

                if (menuKeyNumber == ConsoleKey.None)
                {
                    menuKeyNumber = Console.ReadKey(true).Key;
                }

                switch (menuKeyNumber)
                {
                    case ConsoleKey.D0:

                        return;

                    case ConsoleKey.D1:

                        for (int i = 0; i < 4; ++i)
                        {
                            if (currentSkillCooldowns[i] > 0)
                            {
                                --currentSkillCooldowns[i];
                            }
                        }

                        menuKeyNumber = ConsoleKey.None;

                        break;

                    case ConsoleKey.D2:

                        int skillNumber;

                        Console.WriteLine();

                        Console.Write("스킬 입력(Q, W, E, R): ");

                        var key = Console.ReadKey().Key;

                        Console.WriteLine();

                        if (key == ConsoleKey.Q)
                        {
                            skillNumber = 0;
                        }

                        else if (key == ConsoleKey.W)
                        {
                            skillNumber = 1;
                        }

                        else if (key == ConsoleKey.E)
                        {
                            skillNumber = 2;
                        }

                        else if (key == ConsoleKey.R)
                        {
                            skillNumber = 3;
                        }

                        else
                        {
                            continue;
                        }

                        if (currentSkillCooldowns[skillNumber] == 0)
                        {
                            currentSkillCooldowns[skillNumber] = skillCooldowns[skillNumber];

                            menuKeyNumber = ConsoleKey.None;
                        }

                        else
                        {
                            Console.WriteLine();

                            Console.Write("쿨타임이 돌아오지 않았습니다.");

                            menuKeyNumber = Console.ReadKey(true).Key;
                        }

                        break;

                    default:

                        menuKeyNumber = Console.ReadKey(true).Key;

                        break;
                }
            }
        }
    }
}