/*
이름: 이시온
날짜: 24.12.02

**심화 과제**

- Weapon 이라는 구조체를 하나 만든 후, 속성으로는 문자열 형 name을 가지게 하세요.
- Soilder이라는 구조체를 하나 더 만든 후, 속성으로 Weapon구조체를 3개 담을 수 있는 배열 및 현재 손에 들고 있는 Weapon이 무엇인지 저장할 배열의 인덱스로 사용할 정수형 변수 하나를 작성합니다.
- 메인에 돌아와서 솔져 구조체를 하나 만들어줍니다. 솔져가 가진 무기의 배열에 본인이 희망하는 이름을 담은 무기 3가지를 모두 기입하여 줍니다.
- 함수를 하나 만들되, 인자값으로 정수형과 솔져형 두가지를 받는 void형 함수를 제작할 것입니다. 함수의 이름은 ChangeWeapon으로 하고 기능은 다음과 같습니다.
    - 함수가 호출되면 배열 속의 Weapon 이름들을 전부 출력하고 다음줄에 어떤 무기로 바꿀것인지 콘솔에 적습니다.
    - 유저로부터 1~3사이 정수를 입력받되 1~3이 아닐 경우, 제대로 1~3사이 정수를 입력하라고 콘솔에 입력 후 무한으로 재입력을 요구합니다.
    - 제대로 1,2,3 중 하나를 입력 받았을 경우, 만약 본인의 손에 들고 있는 무기와 같은 무기를 입력하였어도 '현재 들고 있는 무기와 동일합니다' 를 출력 후, 재입력을 요구합니다.
    - 본인 손에 들고 있는 무기와는 다른 무기를 정상적으로 골랐다면 콘솔 출력을 통해 해당 무기로 바뀌었음을 출력합니다.
    - 이후 메인 문에 ChangeWeapon 함수를 3번 실행하되, 아래 각각의 상황에 맞게 호출하세요.
        - 시작 시 본인이 들고 있는 무기와 일치하는 숫자를 유저가 입력한 상황.
        - 1~3이 아닌 숫자를 입력한 상황.
        - 정상적으로 무기 변경이 일어날 수 있는 상황.
*/
using System;

namespace Assignment1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage =
                "**심화 과제**\n" +
                "\n" +
                "- Weapon 이라는 구조체를 하나 만든 후, 속성으로는 문자열 형 name을 가지게 하세요.\n" +
                "- Soilder이라는 구조체를 하나 더 만든 후," +
                "속성으로 Weapon구조체를 3개 담을 수 있는 배열 및" +
                "현재 손에 들고 있는 Weapon이 무엇인지 저장할 배열의 인덱스로 사용할 정수형 변수 하나를 작성합니다.\n" +
                "- 메인에 돌아와서 솔져 구조체를 하나 만들어줍니다." +
                "솔져가 가진 무기의 배열에 본인이 희망하는 이름을 담은 무기 3가지를 모두 기입하여 줍니다.\n" +
                "- 함수를 하나 만들되, 인자값으로 정수형과 솔져형 두가지를 받는 void형 함수를 제작할 것입니다. 함수의 이름은 ChangeWeapon으로 하고 기능은 다음과 같습니다.\n" +
                "    - 함수가 호출되면 배열 속의 Weapon 이름들을 전부 출력하고 다음줄에 어떤 무기로 바꿀것인지 콘솔에 적습니다.\n" +
                "    - 유저로부터 1~3사이 정수를 입력받되 1~3이 아닐 경우, 제대로 1~3사이 정수를 입력하라고 콘솔에 입력 후 무한으로 재입력을 요구합니다.\n" +
                "    - 제대로 1,2,3 중 하나를 입력 받았을 경우, 만약 본인의 손에 들고 있는 무기와 같은 무기를 입력하였어도 '현재 들고 있는 무기와 동일합니다' 를 출력 후, 재입력을 요구합니다.\n" +
                "    - 본인 손에 들고 있는 무기와는 다른 무기를 정상적으로 골랐다면 콘솔 출력을 통해 해당 무기로 바뀌었음을 출력합니다.\n" +
                "    - 이후 메인 문에 ChangeWeapon 함수를 3번 실행하되, 아래 각각의 상황에 맞게 호출하세요.\n" +
                "        - 시작 시 본인이 들고 있는 무기와 일치하는 숫자를 유저가 입력한 상황.\n" +
                "        - 1~3이 아닌 숫자를 입력한 상황.\n" +
                "        - 정상적으로 무기 변경이 일어날 수 있는 상황.";

            // 메인에 돌아와서 솔져 구조체를 하나 만들어줍니다.
            Soilder soilder1 = new()
            {
                // 솔져가 가진 무기의 배열에 본인이 희망하는 이름을 담은 무기 3가지를 모두 기입하여 줍니다.
                weapons =
                [
                    new() { name = "권총" },
                    new() { name = "소총" },
                    new() { name = "산탄총" },
                ],

                currentWeapon = 1,
            };

            // 시작 시 본인이 들고 있는 무기와 일치하는 숫자를 유저가 입력한 상황.
            ChangeWeapon(soilder1);
            // 1~3이 아닌 숫자를 입력한 상황.
            ChangeWeapon(soilder1);
            // 정상적으로 무기 변경이 일어날 수 있는 상황.
            ChangeWeapon(soilder1);
        }

        // 함수를 하나 만들되, 인자값으로 정수형과 솔져형 두가지를 받는 void형 함수를 제작할 것입니다.
        // 함수의 이름은 ChangeWeapon으로 하고 기능은 다음과 같습니다.
        private static void ChangeWeapon(Soilder soilder)
        {
            // 함수가 호출되면 배열 속의 Weapon 이름들을 전부 출력하고
            for (int i = 0; i < soilder.weapons.Length; ++i)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}. {soilder.weapons[i].name}");
                Console.WriteLine();
            }

            int cindex;

            while (true)
            {
                // 다음줄에 어떤 무기로 바꿀것인지 콘솔에 적습니다.
                Console.WriteLine();
                Console.Write($"바꿀 무기 입력(1~{soilder.weapons.Length}): ");
                // 유저로부터 1~3사이 정수를 입력받되
                int.TryParse(Console.ReadLine(), out cindex);

                // 1~3이 아닐 경우,
                if (cindex < 1 || soilder.weapons.Length < cindex)
                {
                    // 제대로 1~3사이 정수를 입력하라고 콘솔에 입력 후 무한으로 재입력을 요구합니다.
                    Console.WriteLine();
                    Console.Write($"1~{soilder.weapons.Length}사이 정수를 입력해주세요.");
                    Console.WriteLine();

                    continue;
                }
                // 제대로 1,2,3 중 하나를 입력 받았을 경우, 만약 본인의 손에 들고 있는 무기와 같은 무기를 입력하였어도
                else if (cindex == soilder.currentWeapon)
                {
                    // '현재 들고 있는 무기와 동일합니다' 를 출력 후,
                    Console.WriteLine();
                    Console.Write("현재 들고 있는 무기와 동일합니다.");
                    Console.WriteLine();

                    // 재입력을 요구합니다.
                    continue;
                }

                break;
            }

            // 본인 손에 들고 있는 무기와는 다른 무기를 정상적으로 골랐다면 콘솔 출력을 통해 해당 무기로 바뀌었음을 출력합니다.
            Console.WriteLine();
            Console.Write($"무기가 {soilder.weapons[cindex].name}로 바뀌었습니다.");
            Console.WriteLine();

            // 이후 메인 문에 ChangeWeapon 함수를 3번 실행하되, 아래 각각의 상황에 맞게 호출하세요.
        }

        // Weapon 이라는 구조체를 하나 만든 후,
        private struct Weapon
        {
            // 속성으로는 문자열 형 name을 가지게 하세요.
            public string name;
        }

        // Soilder이라는 구조체를 하나 더 만든 후,
        private struct Soilder
        {
            // 속성으로 Weapon구조체를 3개 담을 수 있는 배열 및
            public Weapon[] weapons;

            // 현재 손에 들고 있는 Weapon이 무엇인지 저장할 배열의 인덱스로 사용할 정수형 변수 하나를 작성합니다.
            public int currentWeapon;
        }
    }
}