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
using static Assignment1.Program;

namespace Assignment1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player player = new(10000);
            
            Shop shop =
            [
                new Item("무기1", 500, "무기1임.", Item.Type.Weapon, new Statistics(10, 0, 0)),

                new Item("방어구1", 300, "방어구1임", Item.Type.Armor, new Statistics(0, 5, 0)),

                new Item("악세서리1", 200, "악세서리1임", Item.Type.Accessory, new Statistics(0, 0, 20)),
            ];

            while (true)
            {
                Console.Clear();

                Console.WriteLine("       [상점 구현 프로그램]\r\n\r\n   해당하는 숫자의 키를 누르시오\r\n\r\n1. 장비창  2. 인벤토리  3. 상점  4. 종료");

                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1)
                {
                    player.EquipSystem();
                }

                else if (key == ConsoleKey.D2)
                {
                    player.InvetorySystem();
                }

                else if (key == ConsoleKey.D3)
                {
                    shop.MenuSystem(player);
                }

                else if (key == ConsoleKey.D4)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("1, 2, 3, 4만 누르십시오");

                    Thread.Sleep(500);
                }
            }
        }

        public struct Statistics
        {
            public int damage;

            public int defense;

            public int hp;

            public Statistics(int damage, int defense, int hp)
            {
                this.damage = damage;

                this.defense = defense;

                this.hp = hp;
            }

            public static Statistics operator +(Statistics left, Statistics right)
            {
                return new(left.damage + right.damage, left.defense + right.defense, left.hp + right.hp);
            }

            public static Statistics operator -(Statistics left, Statistics right)
            {
                return new(left.damage - right.damage, left.defense - right.defense, left.hp - right.hp);
            }

            public override string ToString()
            {
                return $"공: {damage} 방: {defense} 체: {hp}";
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

            public readonly Type type;

            public readonly Statistics statistics;

            public Item(string name, int price, string explain, Type type, Statistics statistics)
            {
                this.name = name;

                this.price = price;

                this.explain = explain;

                this.type = type;

                this.statistics = statistics;
            }

            // 아이템을 출력할 때, 아이템의 이름, 가격, 설명이 출력되어야 합니다.
            public override string ToString()
            {
                return $"이름: {name}, 가격: {price}, 설명: {explain}";
            }

            public enum Type
            {
                Weapon,

                Armor,

                Accessory,

                Length
            }
        }

        // 플레이어 클래스 (`Player`)
        public sealed class Player
        {
            // 소지금액(int)
            private int moneyAmount;

            private Statistics statistics = new();

            private readonly Dictionary<Item.Type, Item?> equipment = new()
            {
                { Item.Type.Weapon, null },

                { Item.Type.Armor, null },

                { Item.Type.Accessory, null },
            };

            private int equipCount = 0;

            // 인벤토리(Item 리스트)
            private readonly List<Item> inventory = new(64);

            public Player(int moneyAmount)
            {
                this.moneyAmount = moneyAmount;
            }

            public bool TryEquip(Item item)
            {
                if (equipment[item.type] != null)
                {
                    return false;
                }

                statistics += item.statistics;

                equipment[item.type] = item;

                ++equipCount;

                return true;
            }

            public bool TryDetach(Item.Type type, out Item? item)
            {
                item = null;

                if (equipment.ContainsKey(type) == false)
                {
                    return false;
                }

                if (equipment[type] == null)
                {
                    return false;
                }

                item = equipment[type];

                equipment[type] = null;

                statistics -= item.statistics;

                --equipCount;

                return true;
            }

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
            public void WriteMoneyAmount()
            {
                Console.WriteLine($"보유 금액: {moneyAmount}원");
            }

            public void WriteStatistics()
            {
                Console.WriteLine($"[장비로 인한 추가 스탯] {statistics}");
            }

            public void WriteEquipment()
            {
                for (int i = 0, j = 0; j < (int)Item.Type.Length; ++j)
                {
                    if (equipment[(Item.Type)j] == null)
                    {
                        continue;
                    }

                    Console.WriteLine($"[{++i}]. {equipment[(Item.Type)j].name}");
                }
            }

            // `인벤토리 확인()`: 플레이어의 인벤토리에 있는 아이템 목록을 출력합니다.
            public bool WriteInventory()
            {
                if (inventory.Count == 0)
                {
                    Console.WriteLine("인벤토리는 비어있습니다.");

                    return false;
                }

                Console.WriteLine("현재 인벤토리:");

                for (int i = 0; i < inventory.Count; ++i)
                {
                    Console.WriteLine($"[{i + 1}]. {inventory[i].name}");
                }

                return true;
            }

            public void EquipSystem()
            {
                while (true)
                {
                    Console.Clear();

                    if (equipCount == 0)
                    {
                        Console.WriteLine("현재 장착중인 장비 없음");
                    }

                    else
                    {
                        Console.WriteLine("현재 장착중인 장비:");

                        WriteEquipment();

                        Console.WriteLine();
                        
                        WriteStatistics();
                    }

                    Console.WriteLine("\n1. 장착  2. 탈착  3. 메인화면");

                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.D1)
                    {
                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("인벤토리가 비어있습니다.");
                        }

                        else
                        {
                            WriteInventory();

                            Console.WriteLine("\n장착할 아이템 번호를 입력하세요:");

                            int.TryParse(Console.ReadLine(), out var number);

                            if (number < 1 || inventory.Count < number)
                            {
                                Console.WriteLine("잘못된 입력입니다.");
                            }

                            else if (TryEquip(inventory[number - 1]) == true)
                            {
                                Console.WriteLine($"[{inventory[number - 1].name}] 장착 완료!");

                                inventory.RemoveAt(number - 1);
                            }

                            else
                            {
                                Console.WriteLine("해당 부위에 이미 장비가 장착되어 있습니다.");
                            }
                        }
                    }

                    else if (key == ConsoleKey.D2)
                    {
                        if (equipCount == 0)
                        {
                            Console.WriteLine("장착된 장비가 없습니다.");
                        }

                        else
                        {
                            Console.WriteLine("현재 장착된 장비:");

                            WriteEquipment();

                            Console.WriteLine("\n탈착할 아이템 번호를 입력하세요:");

                            int.TryParse(Console.ReadLine(), out var number);

                            if (TryDetach((Item.Type)number - 1, out var item) == true)
                            {
                                Console.WriteLine($"[{item.name}] 탈착 완료!");

                                inventory.Add(item);
                            }

                            else
                            {
                                Console.WriteLine("잘못된 입력입니다.");
                            }
                        }
                    }

                    else if (key == ConsoleKey.D3)
                    {
                        return;
                    }

                    else
                    {
                        Console.WriteLine("1, 2, 3만 누르십시오");
                    }

                    Thread.Sleep(500);
                }
            }

            public void InvetorySystem()
            {
                while (true)
                {
                    Console.Clear();

                    WriteInventory();

                    Console.WriteLine();

                    WriteMoneyAmount();

                    Console.WriteLine("\n버릴 아이템 번호를 입력하세요. (메인 메뉴로 가려면 0 입력)");

                    if (int.TryParse(Console.ReadLine(), out var number) == true)
                    {
                        if (number == 0)
                        {
                            break;
                        }

                        if (number > inventory.Count)
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }

                        else
                        {
                            Console.WriteLine($"[{inventory[number - 1].name}] 아이템을 버렸습니다.");

                            inventory.RemoveAt(number - 1);
                        }

                        Thread.Sleep(500);
                    }
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
                Console.WriteLine("상점 아이템 목록:");

                for (int i = 0; i < itemList.Count; ++i)
                {
                    Console.WriteLine($"[{i + 1}]. {itemList[i].name} - {itemList[i].price}원");
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
                    Console.Clear();

                    WriteItemList();

                    Console.WriteLine("\n구매할 아이템 번호를 입력하세요. (메인 메뉴로 가려면 0 입력)");

                    if (int.TryParse(Console.ReadLine(), out var itemNumber) == true)
                    {
                        if (itemNumber == 0)
                        {
                            break;
                        }

                        if (itemNumber > itemList.Count)
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }

                        else if (TrySellItem(player, itemList[itemNumber - 1]) == true)
                        {
                            Console.WriteLine($"[{itemList[itemNumber - 1].name}]을(를) 구매했습니다!");
                        }

                        else
                        {
                            Console.WriteLine("소지금이 부족합니다.");
                        }

                        Thread.Sleep(500);
                    }
                }
            }
            // 상점에서 판매 중인 아이템 목록 출력
            // 특정 아이템 구매
            // 플레이어의 인벤토리 및 소지금 확인
        }
    }
}