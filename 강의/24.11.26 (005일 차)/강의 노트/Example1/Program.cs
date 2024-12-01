/*
이름: 이시온
날짜: 2024.11.26
 */

using System;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IfExample();
            //IsPlayerAlive();
            //ElseIfExample();
            //RelationalOperatorExample();
            //SwitchExample();
            //ForExample();
            //DoubleForExample();
            //DoubleForExample();
            //WhileExample();
            InfinityLoopExample();
        }

        // if문 예제
        private static void IfExample()
        {
            // if문
            // 괄호 안에 조건식이 true일 경우 중괄호 안에 코드를 실행.
            // 예)
            bool a = true;

            // 만약에 a가 true일 경우,
            if (a)
            {
                // 출력.
                Console.WriteLine("3. True 입니다.");
            }

            a = false;

            // 만약에 a가 true일 경우,
            if (a)
            {
                // 출력. (실행되지 않음)
                Console.WriteLine("4. True 입니다.");
            }
        }

        private static void IsPlayerAliveGame()
        {
            int playerHp = 100;

            int damage = 0;

            Console.WriteLine($"플레이어의 현재 체력은 {playerHp}입니다.");

            Console.Write("받을 데미지: ");

            int.TryParse(Console.ReadLine(), out damage);

            playerHp -= damage;

            Console.WriteLine($"플레이어의 현재 체력은 {playerHp}입니다.");

            if (playerHp <= 0)
            {
                Console.WriteLine("플레이어가 죽었습니다.");

                return;
            }
        }

        // else if, else문 예제
        private static void ElseIfExample()
        {
            // else if, else문
            // 반드시 if, else if문 뒤에 선언해야 함. 앞의 조건문이 실행되지 않았을 때 작동.

            // a 입력.
            int.TryParse(Console.ReadLine(), out int a);

            // 만약에 a를 2로 나눈 나머지가 0일 경우 (2의 배수일 경우),
            if (a % 2 == 0) 
            {
                // 출력.
                Console.WriteLine($"{a}은/는 2의 배수입니다.");
            }
            // 만약에 a를 3으로 나눈 나머지가 0일 경우 (3의 배수일 경우),
            else if (a % 3 == 0)
            {
                // 출력.
                Console.WriteLine($"{a}은/는 3의 배수입니다.");
            }
            // 만약에 모두 아닐 경우,
            else
            {
                // 출력.
                Console.WriteLine($"{a}은/는 이도저도 아닙니다.");
            }
        }

        // 비교 연산자 예제
        private static void RelationalOperatorExample()
        {
            // 비교 연산자(Relational Operator)
            // <, >
            // 좌변과 우변의 크기를 비교. 
            // 
            // bool a = 1 < 2; // a = true;
            // bool b = 1 < 1; // b = false;
            // bool c = 2 > 1; // c = true;
            // bool d = 1 > 1; // d = false;

            // ==, !=
            // 좌변과 우변이 같거나 다른지 비교
            // 
            //bool a = 1 == 1; // a = true;
            //bool b = 1 == 2; // b = false;
            //bool c = 1 != 1; // c = false;
            //bool d = 1 != 2; // d = true;

            // <=, >=
            // 좌변과 우변의 크거나/작거나 같은지 비교. 
            // 
            // bool a = 1 <= 1; // a = true;
            // bool b = 2 <= 1; // b = false;
            // bool c = 1 >= 1; // c = true;
            // bool d = 1 >= 2; // d = false;

            // &&
            // AND 연산. 좌변과 우변 모두 true라면 true, 둥 중 하나라도 false라면 false.
            // 
            // bool a = true && true; // a = true;
            // bool b = true && false; // b = false;
            // bool c = false && true; // c = false;
            // bool d = false && false; // d = false;

            // ||
            // OR 연산. 좌변과 우변 둘 중 하나라도 true라면 true, 모두 false라면 false.
            // 
            // bool a = true || true; // a = true;
            // bool b = true || false; // b = true;
            // bool c = false || true; // c = true;
            // bool d = false || false; // d = false;

            int.TryParse(Console.ReadLine(), out int number);

            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine($"{number}은/는 2와 3의 배수입니다.");
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                Console.WriteLine($"{number}은/는 2 또는 3의 배수입니다.");
            }
            else
            {
                Console.WriteLine($"{number}은/는 이도저도 아닙니다.");
            }
        }

        // switch문 예제
        private static void SwitchExample()
        {
            // switch문
            // if문과 유사하지만, 값이 case에 일치하는 구문으로 이동,
            // break로 탈출하지 않으면 바로 밑 case 구문도 실행.
            // 
            // a 입력
            int a = int.Parse(Console.ReadLine());

            // 만약에 a가
            switch (a)
            {
                // 1일 경우,
                case 1:

                    // 출력.
                    Console.WriteLine("입력된 값은 1 입니다.");

                    break;

                // 2일 경우,
                case 2:

                    // 출력.
                    Console.WriteLine("입력된 값은 2 입니다.");

                    break;

                // 3일 경우,
                case 3:

                    // 출력.
                    Console.WriteLine("입력된 값은 3 입니다.");

                    break;

                // 모두 아닐 경우,
                default:

                    // 출력.
                    Console.WriteLine("유효하지 않은 값입니다.");

                    break;
            }
        }

        // for문 예제
        private static void ForExample()
        {
            // for문
            // 괄호에서 세미콜론으로 구분하여 변수 초기화, 조건식 비교, 증감 연산 수행,
            // 조건식이 true라면 중괄호 안에 코드를 실행, 증감 연산 후 다시 조건식 비교,
            // 일련의 과정을 반복.
            // 
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"i = {i}");
            }
        }

        // n중 for문 예제
        private static void NestedForExample()
        {
            // n중 for문
            // for문 안에 for문을 사용 가능,
            // 바깥 for문이 다시 반복될 때 안에 있는 for문은 초기화.
            // 
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }
        }

        //99단 출력 함수
        private static void Write99Steps()
        {
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }

        private static void WhileExample()
        {
            // while문
            // for문과 유사하지만, 괄호에서 조건식 비교만 수행.
            // 명제가 true라면 중괄호 안에 코드를 실행 후 다시 조건식 비교, 일련의 과정을 반복.
            int i = 0;
            // 만약 i가 10보다 작다면,
            while (i < 10)
            {
                // 출력.
                Console.WriteLine($"{i}");

                // i 증가.
                ++i;
            }
            
        }

        private static void InfinityLoopExample()
        {
            // 무한 반복문
            // 조건식에 true를 넣으면 무한히 반복. break로 중단 가능.

            // break
            // 반복문을 강제로 중단시키는 키워드.

            // 입력 값이 유효할 때 까지 입력.
            while (true)
            {
                Console.Write("숫자 입력: ");

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    Console.WriteLine($"입력 성공. 값은 {value}입니다.");

                    break;
                }
                else
                {
                    Console.WriteLine($"잘못된 입력값입니다.");
                }
            }

            // continue
            // 블록 내의 남은 코드를 무시하고 다음으로 넘어가는 키워드.
            // 반복문 내에서 실행되면 바로 다음 반복으로 넘어감.

            // 입력 값이 유효할 때 까지 입력.
            while (true)
            {
                Console.Write("숫자 입력: ");

                if (int.TryParse(Console.ReadLine(), out int value) == false)
                {
                    Console.WriteLine($"잘못된 입력값입니다.");

                    continue;
                }

                Console.WriteLine($"입력 성공. 값은 {value}입니다.");

                break;
            }
        }
    }
}