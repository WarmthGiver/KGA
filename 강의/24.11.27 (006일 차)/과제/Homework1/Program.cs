/*
이름: 이시온
날짜: 2024.11.27

## **과제 1. 숫자 야구 제작**

※ 배열 없이도 제작 가능합니다

- 컴퓨터는 임의의 세자리 숫자를 가지고 있음. 플레이어가 컴퓨터를 위한 중복되지 않는 임의의 세자리를 입력해주면 됩니다. (컴퓨터가 지 혼자 알고 있을 숫자 102~987)
- 유저는 세자리 수를 입력하되 동일한 자리의 숫자가 있을 경우, 유저에게 다시 입력하라고 반복 시킴.
- 컴퓨터가 정한 수와, 유저가 입력한 숫자를 비교해서 만약 자릿수가 일치한 것이 있다면 스트라이크 수가 늘어남. 예를 들어, 컴퓨터의 수는 142고, 유저 입력은 172면 2스트라이크.
- 컴퓨터의 숫자와 유저가 입력한 숫자를 비교해서 숫자가 존재하긴 하나, 자릿수가 다를 경우, 볼 갯수가 증가. 예를 들어 172가 컴퓨터 숫자고, 127을 유저가 입력했다면 1스트라이크 2볼.
- 유저가 입력한 값 중 어느 하나도 컴퓨터의 숫자와 비교해서 같은 것이 없는 상황엔, 즉 볼과 스트라이크가 모두 없는 상황엔 ‘n스트라이크n볼’ 대신 ‘아웃’ 출력
- 3스트라이크 모두 나올때까지 유저는 계속 입력하게 되며, 유저의 입력 한번 당, 이닝이 하나씩 증가함
- 11이닝이 되기 전까지 3스트라이크를 내면 유저의 승, 11이닝이 될 때까지 3스트라이크가 나오지 않았다면 컴퓨터의 승리
*/

using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 디버그 모드 설정 변수.
            bool debugMode = false;

            #region 무작위 숫자 생성

            Random random = new();

            // 컴퓨터가 생성한 무작위 숫자 3개를 담을 변수.
            int number1, number2, number3;

            // 첫 번째 무작위 숫자 생성(0~9).
            number1 = random.Next(0, 9);

            // 두 번째 숫자가 첫 번째 숫자와 겹치지 않을 때 까지 반복.
            while (true)
            {
                // 두 번째 무작위 숫자 생성(0~9).
                number2 = random.Next(0, 9);

                // 만약 생성된 숫자가 첫 번째 숫자와 겹치지 않으면,
                if (number2 != number1)
                {
                    // 반복문 종료.
                    break;
                }
            }

            // 세 번째 숫자가 나머지 숫자와 겹치지 않을 때 까지 반복.
            while (true)
            {
                // 세 번째 무작위 숫자 생성(0~9).
                number3 = random.Next(0, 9);

                // 만약 생성된 숫자가 나머지 숫자와 겹치지 않으면,
                if (number3 != number1 && number3 != number2)
                {
                    // 반복문 종료.
                    break;
                }
            }

            #endregion

            // 승리 플래그
            bool winFlag = false;

            #region 게임 시작

            Console.WriteLine("[숫자 야구 게임]");

            // 11회말 까지 진행. 11회말 초과시 게임 오버.
            for (int inning = 1; inning <= 11;)
            {
                // 스트라이크, 볼 횟수를 저장하는 변수.
                int strikeCount = 0;
                int ballCount = 0;

                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                Console.WriteLine($"[{inning}회말]");

                // (디버깅)정답 확인
                if (debugMode == true)
                {
                    Console.WriteLine();
                    Console.WriteLine($"(디버깅)정답 = {number1}{number2}{number3}");
                }

                // 입력한 정답을 저장하는 변수.
                int guessNumbers;

                // 입력한 정답을 자리수로 분해하여 저장하는 변수.
                int guessNumber1, guessNumber2, guessNumber3;

                // 입력한 정답이 유효할 때 까지 반복.
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("정답 입력(102~987): ");
                    int.TryParse(Console.ReadLine(), out guessNumbers);

                    // 만약 입력한 정답이 102미만 또는 987초과일 경우,
                    if (guessNumbers < 102 || 987 < guessNumbers)
                    {
                        // 다음 반복으로 넘어감.
                        continue;
                    }

                    // 100의 자리 수는 첫 번째 숫자,
                    // 10의 자리 수는 두 번째 숫자,
                    // 1의 자리 수는 세 번째 숫자.

                    // 100의 자리 숫자를 10으로 나눈 나머지는 1의 자리수.
                    guessNumber3 = guessNumbers % 10;

                    // 1의 자리를 날림.
                    guessNumbers /= 10;
                    // 10의 자리 숫자를 10으로 나눈 나머지는 1의 자리수.
                    guessNumber2 = guessNumbers % 10;

                    // 만약 두 번째 숫자가 세 번째 숫자와 겹친다면,
                    if (guessNumber2 == guessNumber3)
                    {
                        // 다음 반복으로 넘어감.
                        continue;
                    }

                    // 1의 자리를 날림.
                    guessNumbers /= 10;
                    // 100의 자리 숫자를 10으로 나눈 나머지는 1의 자리수.
                    guessNumber1 = guessNumbers;

                    // 만약 첫 번째 숫자가 나머지 숫자와 겹친다면,
                    if (guessNumber1 == guessNumber2 || guessNumber1 == guessNumber3)
                    {
                        // 다음 반복으로 넘어감.
                        continue;
                    }

                    // 반복문 종료.
                    break;
                }
                Console.WriteLine();

                // 만약 입력한 첫 번째 수가 컴퓨터가 생성한 첫 번째 숫자와 일치한다면,
                if (guessNumber1 == number1)
                {
                    // 스트라이크 증가.
                    ++strikeCount;
                }
                // 만약 입력한 첫 번째 수가 컴퓨터가 생성한 나머지 숫자와 일치한다면,
                else if (guessNumber1 == number2 || guessNumber1 == number3)
                {
                    // 볼 증가.
                    ++ballCount;
                }

                // 만약 입력한 두 번째 수가 컴퓨터가 생성한 두 번째 숫자와 일치한다면,
                if (guessNumber2 == number2)
                {
                    // 스트라이크 증가.
                    ++strikeCount;
                }
                // 만약 입력한 두 번째 수가 컴퓨터가 생성한 나머지 숫자와 일치한다면,
                else if (guessNumber2 == number1 || guessNumber2 == number3)
                {
                    // 볼 증가.
                    ++ballCount;
                }

                // 만약 입력한 세 번째 수가 컴퓨터가 생성한 세 번째 숫자와 일치한다면,
                if (guessNumber3 == number3)
                {
                    // 스트라이크 증가.
                    ++strikeCount;
                }
                // 만약 입력한 세 번째 수가 컴퓨터가 생성한 나머지 숫자와 일치한다면,
                else if (guessNumber3 == number1 || guessNumber3 == number2)
                {
                    // 볼 증가.
                    ++ballCount;
                }

                // 만약 일치하는 숫자가 하나도 없다면,
                if (strikeCount == 0 && ballCount == 0)
                {
                    // 아웃만 출력후,
                    Console.Write($"[Out]");
                }
                // 만약 스크라이크 횟수가 3이라면,
                else if (strikeCount == 3)
                {
                    // 승리 플래그 설정 후,
                    winFlag = true;

                    // 반복문 탈출.
                    break;
                }
                // 아니라면,
                else
                {
                    // 스크라이크와 볼 횟수 출력 후,
                    Console.Write($"[{strikeCount} Strike] [{ballCount} Ball]");
                }
                Console.WriteLine();

                // 회말 종료.
                ++inning;
            }

            #endregion

            #region 게임 종료

            // 승리/패배 출력.
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            if (winFlag)
            {
                Console.Write("승리하였습니다.");
            }
            else
            {
                Console.Write("패배하였습니다.");
            }

            // 프로그램이 끝나면 바로 꺼지는 것을 방지.
            Console.ReadKey(true);

            // 게임 종료.
            return;

            #endregion
        }
    }
}