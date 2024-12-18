/*
날짜: 24.12.18
이름: 이시온
*/
/*
### 심화 과제 ) 모작 입문

다양한 자료구조를 직접 활용하여 다음과 같은 내용을 구현합니다.

해당 프로그램을 구동해보고, 모작을 진행합니다. 기능을 분석하고 직접 구현해보는 과제입니다. 상점 NPC가 행하는 기능입니다.

### 참고

1. **아이템 클래스 (`Item`)**
    - 아이템의 기본 속성:
        - 이름 (String)
        - 가격 (int)
        - 설명 (String)
    - 아이템을 출력할 때, 아이템의 이름, 가격, 설명이 출력되어야 합니다.
2. **플레이어 클래스 (`Player`)**
    - 플레이어의 속성:
        - 소지금액 (int)
        - 인벤토리 (Item 리스트)
    - 주요 메서드:
        - `구매(Item item)`: 플레이어가 아이템을 구매하면, 소지금에서 가격만큼 차감되고 인벤토리에 추가됩니다. 소지금이 부족할 경우 구매가 불가능해야 합니다.
        - `소지금 확인()`: 현재 플레이어의 소지금을 반환합니다.
        - `인벤토리 확인()`: 플레이어의 인벤토리에 있는 아이템 목록을 출력합니다.
3. **상점 클래스 (`Shop`)**
    - 상점의 속성:
        - 판매 아이템 목록 (Item 리스트)
    - 주요 메서드:
        - `아이템 목록 출력()`: 상점에서 판매 중인 아이템 목록을 출력합니다.
        - `아이템 판매(Player player, Item item)`: 플레이어가 아이템을 구매할 수 있도록 상점이 아이템을 제공합니다.
        - 아이템 구매 후에는 판매 목록에서 해당 아이템이 사라지지 않아도 됩니다.
4. **상점 메뉴 시스템**
    - 플레이어가 상점을 이용할 수 있는 메뉴 시스템을 제공합니다:
        - 상점에서 판매 중인 아이템 목록 출력
        - 특정 아이템 구매
        - 플레이어의 인벤토리 및 소지금 확인
*/

using System.Collections;

namespace Assignment1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player player = new();

            Shop shop =
            [
                new Item("무기1", 500, "무기1임."),

                new Item("방어구1", 500, "방어구1임"),

                new Item("악세서리1", 500, "악세서리1임"),
            ];

            while (true)
            {
                Console.WriteLine("       [상점 구현 프로그램]\r\n\r\n   해당하는 숫자의 키를 누르시오\r\n\r\n1. 장비창  2. 인벤토리  3. 상점  4. 종료");

                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1)
                {

                }

                else if (key == ConsoleKey.D2)
                {

                }

                else if (key == ConsoleKey.D3)
                {
                    shop.MenuSystem();
                }

                else if (key == ConsoleKey.D4)
                {
                    break;
                }
            }
        }

        // 아이템 클래스(`Item`)
        public sealed class Item
        {
            // 이름(String)
            public readonly string name;

            // 가격(int)
            public readonly int price;

            // 설명(String)
            public readonly string explain;

            public Item(string name, int price, string explain)
            {
                this.name = name;

                this.price = price;

                this.explain = explain;
            }

            // 아이템을 출력할 때, 아이템의 이름, 가격, 설명이 출력되어야 합니다.
            public override string ToString()
            {
                return $"이름: {name}, 가격: {price}, 설명: {explain}";
            }
        }

        // 플레이어 클래스 (`Player`)
        public sealed class Player
        {
            // 소지금액(int)
            private int moneyAmount;

            // 인벤토리(Item 리스트)
            private readonly List<Item> inventory = new(128);

            // `구매(Item item)`: 플레이어가 아이템을 구매하면, 소지금에서 가격만큼 차감되고 인벤토리에 추가됩니다.소지금이 부족할 경우 구매가 불가능해야 합니다.
            public bool TryBuyItem(Item item)
            {
                if (moneyAmount < item.price)
                {
                    return false;
                }

                moneyAmount -= item.price;

                inventory.Add(item);

                return true;
            }

            // `소지금 확인()`: 현재 플레이어의 소지금을 반환합니다.
            public int GetMoneyAmount()
            {
                return moneyAmount;
            }

            // `인벤토리 확인()`: 플레이어의 인벤토리에 있는 아이템 목록을 출력합니다.
            public void WriteInventory()
            {
                foreach (var item in inventory)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // 상점 클래스 (`Shop`)
        public sealed class Shop : IEnumerable
        {
            // 판매 아이템 목록(Item 리스트)
            private readonly List<Item> itemList;

            public Shop(params Item[] items)
            {
                itemList = [.. items];
            }

            public IEnumerator GetEnumerator()
            {
                return itemList.GetEnumerator();
            }

            public void Add(Item item)
            {
                itemList.Add(item);
            }

            // `아이템 목록 출력()`: 상점에서 판매 중인 아이템 목록을 출력합니다.
            private void WriteItemList()
            {
                for (int i = 0; i < itemList.Count; ++i)
                {
                    Console.WriteLine($"[{i}]. {itemList[i].name} - {itemList[i].price}원");
                }
            }

            // `아이템 판매(Player player, Item item)`: 플레이어가 아이템을 구매할 수 있도록 상점이 아이템을 제공합니다.
            private bool TrySellItem(Player player, Item item)
            {
                // 아이템 구매 후에는 판매 목록에서 해당 아이템이 사라지지 않아도 됩니다.
                return player.TryBuyItem(item);
            }

            // 상점 메뉴 시스템
            // 플레이어가 상점을 이용할 수 있는 메뉴 시스템을 제공합니다:
            public void MenuSystem(Player player)
            {
                while (true)
                {
                    WriteItemList();

                    Console.WriteLine("\n구매할 아이템 번호를 입력하세요. (메인 메뉴로 가려면 0 입력)");

                    if (int.TryParse(Console.ReadLine(), out var itemNumber) == false)
                    {
                        continue;
                    }

                    if (itemNumber == 0)
                    {
                        break;
                    }

                    if (itemNumber > itemList.Count)
                    {
                        Console.WriteLine("잘못된 입력입니다.");

                        Thread.Sleep(1000);

                        continue;
                    }

                    TrySellItem(player, itemList[itemNumber]);
                }
            }
            // 상점에서 판매 중인 아이템 목록 출력
            // 특정 아이템 구매
            // 플레이어의 인벤토리 및 소지금 확인
        }
    }
}