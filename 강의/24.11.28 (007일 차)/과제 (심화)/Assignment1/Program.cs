/*
이름: 이시온
날짜: 24.11.28

**심화 과제 1**

1차원 스트링 배열을 하나 만들고, 유저에게 원하는 크기를 입력받아 생성함.
숫자가 아니거나, 음수거나, 10이 넘어가는 숫자를 입력시, 무한으로 재요구 하기.
생성 후, n칸의 인벤토리가 생성되었다고 출력하기. 

※생성과 동시에 이런식으로 “” 으로 초기화 (예시)
https://img.notionusercontent.com/s3/prod-files-secure%2Fecbfc15b-d9e9-421e-911d-a5bceae47cb4%2Ff3797ddb-4c1b-4573-a335-387673684851%2Fimage.png/size/w=700?exp=1732864341&sig=xfLfy9BxDYAu00M51_Ss4CDB1tQKV36Sauzol5uk_rs

유저에게 무한 반복으로 몇번째 칸을 열람하겠냐고 숫자를 입력 받은 후,
해당 칸이 "", 즉 비어있었다면 , "비어있습니다. 넣고자 하는 값을 입력하세요" 출력,
해당 칸이 ""가 아닌 값이 들어있었다면 해당 값을 출력하기.
종료를 원하면 0을 입력하라고 하기.

1. "원하는 인벤토리의 크기를 입력하세요" 출력 후 숫자 입력받기. 1~10 아니면 무한반복
2. "n개 만큼의 인벤토리가 생성되었습니다" 출력
3. "열람을 원하는 번호를 입력해주시기 바랍니다" 출력 후 유저의 입력 받기
4. 칸이 비어있다면("" 이 들어있다면) "칸이 비었습니다. 값을 입력하세요" 출력
5. 번호에 해당하는 칸에 내용물이 있었다면 해당 내용을 출력
6. 출력 후 다시 입력 받을 수 있게 무한 반복
7. 0을 입력받으면 무한반복 종료
*/
using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passage =
                "**심화 과제 1**\n" +
                "\n" +
                "1차원 스트링 배열을 하나 만들고, 유저에게 원하는 크기를 입력받아 생성함.\n" +
                "숫자가 아니거나, 음수거나, 10이 넘어가는 숫자를 입력시, 무한으로 재요구 하기.\n" +
                "생성 후, n칸의 인벤토리가 생성되었다고 출력하기.\n" +
                "유저에게 무한 반복으로 몇번째 칸을 열람하겠냐고 숫자를 입력 받은 후,\n" +
                "해당 칸이 \"\", 즉 비어있었다면, \"비어있습니다. 넣고자 하는 값을 입력하세요\" 출력,\n" +
                "해당 칸이 \"\"가 아닌 값이 들어있었다면 해당 값을 출력하기.\n" +
                "종료를 원하면 0을 입력하라고 하기.";

            Console.WriteLine();
            Console.Write(passage);
            Console.WriteLine();

            int capacity;

            //숫자가 아니거나, 음수거나, 10이 넘어가는 숫자를 입력시, 무한으로 재요구 하기.
            while (true)
            {
                Console.WriteLine();
                Console.Write("원하는 인벤토리의 크기를 입력하세요(1~10): ");
                int.TryParse(Console.ReadLine(), out capacity);

                if (1 <= capacity && capacity <= 10)
                {
                    break;
                }
            }

            // 1차원 스트링 배열을 하나 만들고, 유저에게 원하는 크기를 입력받아 생성함.
            string[] inventory = new string[capacity];

            for (int i = 0; i < capacity; ++i)
            {
                inventory[i] = "";
            }

            // 생성 후, n칸의 인벤토리가 생성되었다고 출력하기.
            Console.WriteLine();
            Console.Write($"{capacity}개 만큼의 인벤토리가 생성되었습니다");
            Console.WriteLine();

            // 유저에게 무한 반복으로 몇번째 칸을 열람하겠냐고 숫자를 입력 받은 후,
            while (true)
            {
                Console.WriteLine();
                Console.Write("열람을 원하는 번호를 입력해주시기 바랍니다(종료: 0): ");
                bool isValid = int.TryParse(Console.ReadLine(), out int number);

                if (isValid == false)
                {
                    continue;
                }

                if (1 <= number && number <= capacity)
                {
                    string item = inventory[number - 1];

                    // 해당 칸이 "", 즉 비어있었다면, "비어있습니다. 넣고자 하는 값을 입력하세요" 출력,
                    if (item == "")
                    {
                        Console.WriteLine();
                        Console.Write("칸이 비었습니다. 넣고자 하는 값을 입력하세요: ");
                        inventory[number - 1] = Console.ReadLine();
                    }
                    // 해당 칸이 ""가 아닌 값이 들어있었다면 해당 값을 출력하기.
                    else
                    {
                        Console.WriteLine();
                        Console.Write($"칸에 들어있는 값: {item}");
                        Console.WriteLine();
                    }
                }
                // 종료를 원하면 0을 입력하라고 하기.
                else if (number == 0)
                {
                    break;
                }
            }
        }
    }
}