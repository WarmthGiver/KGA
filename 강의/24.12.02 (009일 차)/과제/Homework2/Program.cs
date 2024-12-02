/*
이름: 이시온
날짜: 24.12.02

**과제 2. 상태를 열거형으로 구현**

- 누군가가 만든 프로그램에서, 플레이어의 현재 행동이 int state 로 정의되어 있습니다. state변수에 1이 담겨 있으면 idle, 2가 담겨있으면 run, 3이 들어있으면 walk , 9가 담겨있으면 죽은 상태 입니다. 열거형을 활용하여 해당 코드를 어떻게 수정할 수 있는지 작성해주세요. 유저에게 콘솔 입력으로 1,2,3,9 외의 입력이 들어오면, 옳지 못한 입력이라고 출력 후, 다시 입력을 요구하는 기능을 만드세요.
    
    
    - 제대로 입력이 되었다면, 예를 들어 run에 해당하는 상태가 입력되었다면 idle에서 run으로 바뀌었다는 멘트 출력
    - 이미 idle 상태였는데 idle 상태가 또 입력되면 ‘이미 idle상태입니다’ 출력
    - 입력 받고 다시 무한으로 계속 진행. 9가 입력되면 ‘죽었다는 관련 멘트’ 나오고 무한루프 종료
*/
using System;

namespace Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage =
                "**과제 2. 상태를 열거형으로 구현**\n" +
                "\n" +
                "- 누군가가 만든 프로그램에서, 플레이어의 현재 행동이 int state 로 정의되어 있습니다." +
                "state변수에 1이 담겨 있으면 idle, 2가 담겨있으면 run, 3이 들어있으면 walk , 9가 담겨있으면 죽은 상태 입니다." +
                "열거형을 활용하여 해당 코드를 어떻게 수정할 수 있는지 작성해주세요." +
                "유저에게 콘솔 입력으로 1,2,3,9 외의 입력이 들어오면, 옳지 못한 입력이라고 출력 후, 다시 입력을 요구하는 기능을 만드세요.\n" +
                "\n" +
                "\n" +
                "    - 제대로 입력이 되었다면, 예를 들어 run에 해당하는 상태가 입력되었다면 idle에서 run으로 바뀌었다는 멘트 출력\n" +
                "    - 이미 idle 상태였는데 idle 상태가 또 입력되면 ‘이미 idle상태입니다’ 출력\n" +
                "    - 입력 받고 다시 무한으로 계속 진행. 9가 입력되면 ‘죽었다는 관련 멘트’ 나오고 무한루프 종료";

            Console.WriteLine();
            Console.Write(passage);
            Console.WriteLine();

            int state = 1;

            while (true)
            {
                Console.WriteLine();
                Console.Write("--------------------------------------------------");
                Console.WriteLine();

                Console.WriteLine();
                Console.Write($"현재 플레이어 상태: {(PlayerState)state}");
                Console.WriteLine();

                Console.WriteLine();
                Console.Write("플레이어 행동 입력: ");
                int.TryParse(Console.ReadLine(), out var state_new);

                Console.WriteLine();
                Console.Write("--------------------------------------------------");
                Console.WriteLine();

                if (state_new == state)
                {
                    Console.WriteLine();
                    Console.Write($"플레이어의 상태가 바뀌지 않았습니다.");
                    Console.WriteLine();

                    continue;
                }

                if (state_new == 1 || state_new == 2 || state_new == 3)
                {
                    Console.WriteLine();
                    Console.Write($"플레이어의 상태가 {(PlayerState)state}에서 {(PlayerState)state_new}로 바뀌었습니다.");
                    Console.WriteLine();

                    state = state_new;

                    continue;
                }

                if (state_new == 9)
                {
                    Console.WriteLine();
                    Console.Write($"플레이어가 죽었습니다.");
                    Console.WriteLine();

                    break;
                }

                Console.WriteLine();
                Console.Write("옳지 못한 입력입니다.");
                Console.WriteLine();
            }
        }

        private enum PlayerState
        {
            idle = 1,
            run = 2,
            walk = 3,
            dead = 9,
        }
    }
}