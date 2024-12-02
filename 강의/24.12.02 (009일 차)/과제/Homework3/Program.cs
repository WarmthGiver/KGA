/*
이름: 이시온
날짜: 24.12.02

**과제 3. 구조체 활용하기**

- 다음 조건에 따라 기능을 제작하세요. 함수를 써도, 메인에서 다 만들어도 됩니다
    - short형x, short형y 두가지를 가진 XYCoord라는 구조체를 선언한다.
    - 정수형 Dmg, 실수형 Critical, 문자열형 Name을 가진 구조체 틀을 만들고 구조체 이름은 Weapon으로 선언한다.
    - 방금 만들어진 구조체 틀을 활용하여, Sword와 Katana라는 객체를 만든 후, 본인이 원하는 수치를 각각 속성에 전부 추가한다.
    - Car라는 구조체를 만든 후, 다음의 내부 속성을 추가한다.
        - `실수형 최고속도`
        - `정수형 자동차넘버`
        - `열거형 제조사(Honda, Audi, BMW, Kia 네가지 열거 속성 보유)`
    - Item 이라는 구조체를 만든다. 이 아이템이라는 구조체는 문자열형인 아이템 이름, 정수형인 가격, 열거형인 아이템 타입(방어구, 무기, 소모품)의 속성을 가진다.
    - 아이템이 3개 들어가는 인벤토리라는 배열을 만들고, 배열 속 세번째 요소에, 아이템명으로 “악몽의 꽃 견갑”, 가격은 500, 아이템의 타입은 방어구이다.
    - 인벤토리의 모든 속 내용을 출력하는 함수를 작성한다.
*/
using System;

namespace Homework3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage =
                "**과제 3. 구조체 활용하기**\n" +
                "\n" +
                "- 다음 조건에 따라 기능을 제작하세요. 함수를 써도, 메인에서 다 만들어도 됩니다\n" +
                "    - short형x, short형y 두가지를 가진 XYCoord라는 구조체를 선언한다.\n" +
                "    - 정수형 Dmg, 실수형 Critical, 문자열형 Name을 가진 구조체 틀을 만들고 구조체 이름은 Weapon으로 선언한다.\n" +
                "    - 방금 만들어진 구조체 틀을 활용하여, Sword와 Katana라는 객체를 만든 후, 본인이 원하는 수치를 각각 속성에 전부 추가한다.\n" +
                "    - Car라는 구조체를 만든 후, 다음의 내부 속성을 추가한다.\n" +
                "        - `실수형 최고속도`\n" +
                "        - `정수형 자동차넘버`\n" +
                "        - `열거형 제조사(Honda, Audi, BMW, Kia 네가지 열거 속성 보유)`\n" +
                "    - Item 이라는 구조체를 만든다. 이 아이템이라는 구조체는 문자열형인 아이템 이름, 정수형인 가격, 열거형인 아이템 타입(방어구, 무기, 소모품)의 속성을 가진다.\n" +
                "    - 아이템이 3개 들어가는 인벤토리라는 배열을 만들고, 배열 속 세번째 요소에, 아이템명으로 “악몽의 꽃 견갑”, 가격은 500, 아이템의 타입은 방어구이다.\n" +
                "    - 인벤토리의 모든 속 내용을 출력하는 함수를 작성한다.";

            Console.WriteLine();
            Console.Write(passage);
            Console.WriteLine();

            Weapon sword = new Weapon()
            {
                dmg = 100,
                critical = 10,
                name = "sword",
            };

            Weapon katana = new Weapon()
            {
                dmg = 50,
                critical = 20,
                name = "katana",
            };

            Item[] inventory = new Item[3];

            inventory[2] = new Item()
            {
                name = "악몽의 꽃 견갑",
                price = 500,
                type = ItemType.방어구,
            };

            foreach (Item item in inventory)
            {
                if (item.name == null)
                {
                    continue;
                }

                Console.WriteLine();
                Console.Write($"이름: {item.name}");
                Console.WriteLine();
                Console.Write($"가격: {item.price}");
                Console.WriteLine();
                Console.Write($"타입: {item.type}");
                Console.WriteLine();
            }
        }

        private struct XYCoord
        {
            public short x;
            public short y;
        }

        private struct Weapon
        {
            public uint dmg;
            public float critical;
            public string name;
        }

        private struct Car
        {
            public float maxSpeed;
            public int number;
            public CarMaker maker;
        }

        private enum CarMaker
        {
            Honda,
            Audi,
            BMW,
            Kia,
        }

        private struct Item
        {
            public string name;
            public int price;
            public ItemType type;
        }

        private enum ItemType
        {
            방어구,
            무기,
            소모품,
        }
    }
}