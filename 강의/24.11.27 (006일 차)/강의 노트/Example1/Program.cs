/*
이름: 이시온
날짜: 2024.11.27
 */

using System;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ConsoleKeyExample1();

            //MovePlayerGame();

            //DebugerExample1();

            //DebugerExample2();

            RandomExample();
        }

        // ConsoleKey 예제 1
        private static void ConsoleKeyExample1()
        {
            // Console.ReadKey()
            // 콘솔에서 입력된 키보드의 값(Key)을 반환해주는 함수.
            // 매개변수로 true를 넘겨주면 입력된 문자열이 콘촐에 출력되지 않음.

            // CosoleKeyInfo
            // 콘솔에서 입력된 키보드의 값(Key)를 담는 구조체(struct).
            // 
            // 값는 ConsoleKey라는 열거형(enum)으로 저장됨.

            ConsoleKeyInfo consoleKey = Console.ReadKey(true);

            switch (consoleKey.Key)
            {
                case ConsoleKey.W:

                    Console.WriteLine("위로 이동");

                    break;

                case ConsoleKey.S:

                    Console.WriteLine("아래로 이동");

                    break;

                case ConsoleKey.A:

                    Console.WriteLine("왼쪽으로 이동");

                    break;

                case ConsoleKey.D:

                    Console.WriteLine("오른쪽으로 이동");

                    break;
            }
        }

        // 플레이어 이동 게임
        private static void MovePlayerGame()
        {
            Console.CursorVisible = false;

            int minWindowSizeX = 0;

            int minWindowSizeY = 0;

            int maxWindowSizeX = 20;

            int maxWindowSizeY = 10;

            Console.SetWindowSize(maxWindowSizeX + 2, maxWindowSizeY);

            int cursorPositionX = 0;

            int cursorPositionY = 0;

            while (true)
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);

                Console.Write("옷");

                ConsoleKeyInfo consoleKey = Console.ReadKey(true);

                Console.SetCursorPosition(cursorPositionX, cursorPositionY);

                Console.Write("　");

                switch (consoleKey.Key)
                {
                    case ConsoleKey.W:

                        if (cursorPositionY > minWindowSizeY)
                        {
                            cursorPositionY -= 1;
                        }

                        break;

                    case ConsoleKey.S:

                        if (cursorPositionY < maxWindowSizeY)
                        {
                            cursorPositionY += 1;
                        }

                        break;

                    case ConsoleKey.A:

                        if (cursorPositionX > minWindowSizeX)
                        {
                            cursorPositionX -= 2;
                        }

                        break;

                    case ConsoleKey.D:

                        if (cursorPositionX < maxWindowSizeX)
                        {
                            cursorPositionX += 2;
                        }

                        break;

                    default:

                        break;
                }
            }
        }

        // Debuger 예제 1
        private static void DebugerExample1()
        {
            // 디버거
            // 비주얼 스튜디오의 경우, 편집기에서 F10 또는 F11번을 눌러 프로그램을 실행하면 디버그 모드에 돌입.
            // 콘솔이 뜬 뒤에 편집기에서 F10, F11을 눌러 코드를 단계적으로 실행 가능.
            // F10을 누르면 프로시저 단위로 실행.
            // F11을 누르면 코드 단위로 실행.

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"i = {i}");
            }
        }

        // Debuger 예제 2
        private static void DebugerExample2()
        {
            // Locals 창
            // 디버그 모드에서 변수의 현재 값을 확인 가능한 창.
            // 디버그 모드에 돌입하면 좌측 하단(기본값)에 출력됨.

            // 중단점(Breakpoint)
            // 편집기 맨 왼쪽 빈 공간을 클릭하여 실행중에 멈추고자 하는 지점을 설정 가능.

            // Convert.ToString(*Inteter Type* value, int toBase)
            // 정수를 2진법으로 변환하여 문자열로 반환해주는 함수.

            int value = -1;

            int power = 2;

            int maxDigits = 32;

            while (true)
            {
                value *= 2;

                Console.WriteLine($"square = {value}");

                string binary = Convert.ToString(value, power);

                Console.WriteLine($"binary = {binary}");

                if (binary.Length >= maxDigits)
                {
                    break;
                }
            }
        }

        // Random 예제
        private static void RandomExample()
        {
            // Random
            // 무작위의 값을 생성할 수 있는 클래스(class).

            // Random.Next(int minValue, int maxValue)
            // 범위 내의 무작위 값을 생성하여 반환하는 함수.

            Random random = new();

            Console.Write("minValue: ");

            int minValue = int.Parse(Console.ReadLine());

            Console.Write("maxValue: ");

            int maxValue = int.Parse(Console.ReadLine());

            int randomValue = random.Next(minValue, maxValue);

            Console.WriteLine($"randomValue: {randomValue}");
        }
    }
}