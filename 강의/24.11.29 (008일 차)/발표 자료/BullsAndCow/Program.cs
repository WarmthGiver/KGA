using System;

namespace BullsAndCow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 디버그 모드 설정 변수.
            bool debugMode = true;

            #region 무작위 숫자 생성

            // 컴퓨터가 생성한 무작위 숫자 3개를 담을 변수.
            int number1, number2, number3;

            Random random = new();

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

            Console.WriteLine();
            Console.Write("[숫자 야구 게임]");
            Console.WriteLine();

            // 11회말 까지 진행. 11회말 초과시 게임 오버.
            for (int inning = 1; inning <= 11;)
            {
                // 스트라이크, 볼 횟수를 저장하는 변수.
                int strikeCount = 0, ballCount = 0;

                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                Console.Write($"[{inning}회말 시작]");
                Console.WriteLine();

                // (디버깅)정답 확인
                if (debugMode == true)
                {
                    Console.WriteLine();
                    Console.Write($"(디버깅) 정답: {number1}{number2}{number3}");
                    Console.WriteLine();
                }

                // 입력한 정답을 저장하는 변수.
                int guessNumbers;

                // 입력한 정답을 자리수로 분해하여 저장하는 변수.
                int guessNumber1, guessNumber2, guessNumber3;

                // 입력한 정답이 유효할 때 까지 반복.
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("정답 입력(012~987): ");
                    int.TryParse(Console.ReadLine(), out guessNumbers);

                    // 100의 자리 수는 첫 번째 숫자,
                    // 10의 자리 수는 두 번째 숫자,
                    // 1의 자리 수는 세 번째 숫자.

                    // 숫자를 10으로 나눈 나머지는 1의 자리수.
                    guessNumber3 = guessNumbers % 10;

                    // 1의 자리를 날림.
                    guessNumbers /= 10;

                    // 숫자를 10으로 나눈 나머지는 1의 자리수.
                    guessNumber2 = guessNumbers % 10;

                    // 만약 두 번째 숫자가 세 번째 숫자와 겹친다면,
                    if (guessNumber2 == guessNumber3)
                    {
                        // 다음 반복으로 넘어감.
                        continue;
                    }

                    // 1의 자리를 날림.
                    guessNumbers /= 10;

                    // 숫자를 10으로 나눈 나머지는 1의 자리수.
                    guessNumber1 = guessNumbers % 10;
                    // 만약 첫 번째 숫자가 나머지 숫자와 겹친다면,
                    if (guessNumber1 == guessNumber2 || guessNumber1 == guessNumber3)
                    {
                        // 다음 반복으로 넘어감.
                        continue;
                    }

                    // 겹치는 숫자가 없다면 반복문 종료.
                    break;
                }

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

                Console.WriteLine();
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                Console.Write($"[{inning}회말 종료]");
                Console.WriteLine();

                Console.WriteLine();
                Console.Write($"입력: {guessNumber1}{guessNumber2}{guessNumber3}");
                Console.WriteLine();

                Console.WriteLine();
                Console.Write($"결과: ");
                // 만약 일치하는 숫자가 하나도 없다면,
                if (strikeCount == 0 && ballCount == 0)
                {
                    // 아웃만 출력후,
                    Console.Write("Out");
                }
                // 아니라면,
                else
                {
                    // 스크라이크와 볼 횟수 출력 후,
                    Console.Write($"{strikeCount} Strike, {ballCount} Ball");
                }
                Console.WriteLine();

                // 만약 스크라이크 횟수가 3이라면,
                if (strikeCount == 3)
                {
                    // 승리 플래그 설정 후,
                    winFlag = true;

                    // 반복문 탈출.
                    break;
                }

                // 회말 종료.
                ++inning;
            }

            #endregion

            #region 게임 종료

            // 승리/패배 출력.
            Console.WriteLine();
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
            Console.WriteLine();

            // 프로그램이 끝나면 바로 꺼지는 것을 방지.
            Console.ReadKey(true);

            // 게임 종료.
            return;

            #endregion
        }
    }
}