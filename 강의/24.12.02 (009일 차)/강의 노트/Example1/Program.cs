/*
이름: 이시온
날짜: 24.12.02
*/
using System;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //BubbleSortExample1();

            //EnumExample1();
            //EnumExample2();

            //StructExample1();
            StructExample2();
        }

        #region 버블 정렬 예제

        private static void BubbleSortExample1()
        {
            int[] array = { 8, 2, 9, 1, 7, 3, 6, 4, 5, };

            WriteArray(array);

            BubbleSort(array);
        }

        private static void WriteArray(int[] array)
        {
            Console.WriteLine();
            Console.Write("array = { ");
            foreach (int element in array)
            {
                Console.Write($"{element}, ");
            }
            Console.Write("}");
            Console.WriteLine();
        }

        private static void BubbleSort(int[] array)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                for (int j = 1; j < array.Length; ++j)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];

                        array[j] = array[j - 1];

                        array[j - 1] = temp;

                        WriteArray(array);
                    }
                }
            }
        }

        #endregion

        #region 열거형(Enum) 예제

        private enum MapType
        {
            Default = 0,

            Village = 1,

            Shop = 2,
        }
        
        private static void EnumExample1()
        {
            // Enum
            // 상수들의 집합을 정의하는 데 사용되는 데이터 타입.

            // 문자열 또는 정수로 입력, 변환, 출력 가능.
            Console.WriteLine();
            Console.Write("MapType: ");
            Enum.TryParse(Console.ReadLine(), out MapType mapType);

            Console.WriteLine();
            switch (mapType)
            {
                case MapType.Default:

                    Console.Write("없음");

                    break;

                case MapType.Village:

                    Console.Write("마을");

                    break;

                case MapType.Shop:

                    Console.Write("상점");

                    break;
            }
            Console.WriteLine();
        }

        private static void EnumExample2()
        {
            Console.WriteLine();
            WriteWithColor("Red", ConsoleColor.Red);
            Console.WriteLine();

            Console.WriteLine();
            WriteWithColor("Blue", ConsoleColor.Blue);
            Console.WriteLine();
        }

        private static void WriteWithColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        #endregion

        #region 구조체(struct) 예제 1

        private struct PersonalInfo
        {
            public string name;
            public byte age;
            public bool sex;

            public PersonalInfo(string name, byte age, bool sex)
            {
                this.name = name;
                this.age = age;
                this.sex = sex;
            }
        }

        private static void StructExample1()
        {
            // 구조체(struct)
            // 

            // 멤버 변수
            // 

            // 생성자
            // 

            // 멤버 함수
            // 

            // 접근 지정자(Access Modifiers)
            // 구조체/클래스와 멤버 변수/함수의 접근 수준을 지정.

            // public
            // 어디서든 접근 가능.

            // private
            // 선언된 곳 내부에서만 접근 가능.

            // protected
            // 선언된 곳 및 상속받은 곳에서만 접근 가능.

            // internal
            // 같은 어셈블리(프로젝트) 내에서 접근 가능. 

            // protected internal
            // 같은 어셈블리 또는 다른 어셈블리의 상속받은 곳에서만 접근 가능.

            // private protected
            // 같은 어셈블리 내 또는 상속받은 곳에서만 접근 가능(C# 7.2부터).

            //string name2 = "철수";
            //byte age2 = 23;
            //bool sex2 = false;

            //string name3 = "영희";
            //byte age3 = 21;
            //bool sex3 = true;

            PersonalInfo personalInfo1 = new()
            {
                name = "철수",
                age = 23,
                sex = false
            };

            PersonalInfo personalInfo2 = new("영희", 21, true);
        }

        #endregion

        #region 구조체(struct) 예제 2

        private enum ItemType
        {
            무기,
            방어구,
            소모품,
        }

        private struct Item
        {
            public string name;
            public uint price;
            public ItemType itemType;
            public float dropChance;

            public Item(string name, uint price, ItemType itemType, float dropChance)
            {
                this.name = name;
                this.price = price;
                this.itemType = itemType;
                this.dropChance = dropChance;
            }
        }

        private static void StructExample2()
        {
            Item[] inventory =
            [
                new Item("황갑충", 300000, ItemType.무기, 0.1f),
                new Item("다크 스타라이트", 50000, ItemType.방어구, 0.5f),
                new Item("뇌전 수리검", 10000, ItemType.소모품, 0.01f),
            ];

            for (int i = 0; i < inventory.Length; ++i)
            {
                Console.WriteLine();
                Console.Write($"이름: {inventory[i].name}");
                Console.WriteLine();
                Console.Write($"가격: {inventory[i].price}");
                Console.WriteLine();
                Console.Write($"타입: {inventory[i].itemType}");
                Console.WriteLine();
                Console.Write($"드롭: {inventory[i].dropChance}%");
                Console.WriteLine();
            }
        }

        #endregion
    }
}