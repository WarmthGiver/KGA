/*
날짜: 24.12.16
이름: 이시온
*/
/*
### 파생 심화 과제) 리팩토링

- Player 클래스에 Weapon들을 보유할 수 있게 하겠습니다. 이를 효율적으로 관리하기 위한 본인만의 방법을 생각해 구현해보시길 바랍니다.
    - 아이템과 무기를 따로 보유하거나, 상속을 받게 하거나, 2중 배열을 쓰거나, 인덱서를 쓰거나 인터페이스를 적용시켜도, 제네릭을 써도 무방합니다. 내부가 어떠하든 바로 아래 기능만 잘 수행하면 됩니다.
    - 추가적으로 Add메서드를 리메이크 하거나, 별도의 추가 방법을 고안하셔도 좋습니다. Weapon 관련 메서드들도 필요 시 추가합니다.
- Player 에게 UseMyItem 이란 메서드를 하나 만듭니다.
    - 인자 및 반환값은 없습니다.
    - 실행이 되면 콘솔에 유저에게 “무기 목록을 보려면 1번, 사용 가능 아이템 목록을 보려면 2번 기입” 을 출력시키고 입력받습니다
    - 유저 입력값에 따라 “???의 목록은 다음과 같습니다” 로 출력 수행
- 이를 테스트 하기 위해 메인에서 다양한 아이템 및 무기를 추가해보는 코드 및 출력한는 코드를 작성해봅니다.
*/

namespace Assignment1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 이를 테스트 하기 위해 메인에서 다양한 아이템 및 무기를 추가해보는 코드 및 출력한는 코드를 작성해봅니다.
            Player player = new();

            player.AddItem(new("빨간 포션", 3));

            player.AddWeapon(new("몽둥이", 19));

            player.UseMyItem();
        }

        public sealed class Player
        {
            private readonly List<Item> items = new();

            // Player 클래스에 Weapon들을 보유할 수 있게 하겠습니다. 이를 효율적으로 관리하기 위한 본인만의 방법을 생각해 구현해보시길 바랍니다.
            private readonly List<Weapon> weapons = new();

            private bool isPayment;

            public bool IsPayment
            {
                get => isPayment;

                set => isPayment = value;
            }

            public void AddItem(Item item)
            {
                if (isPayment == false && items.Count >= 30)
                {
                    Console.WriteLine("인벤토리가 꽉 찼습니다.");

                    return;
                }

                items.Add(item);
            }

            public void AddWeapon(Weapon weapon)
            {
                if (isPayment == false && weapons.Count >= 30)
                {
                    Console.WriteLine("인벤토리가 꽉 찼습니다.");

                    return;
                }

                weapons.Add(weapon);
            }

            public void ShowWeapons()
            {
                foreach (var weapon in weapons)
                {
                    Console.WriteLine($"1. {weapon.ToString()}");
                }
            }

            public void ShowItems()
            {
                foreach (var item in items)
                {
                    Console.WriteLine($"1. {item.ToString()}");
                }
            }

            // Player 에게 UseMyItem 이란 메서드를 하나 만듭니다.
            // 인자 및 반환값은 없습니다.
            public void UseMyItem()
            {
                // 실행이 되면 콘솔에 유저에게 “무기 목록을 보려면 1번, 사용 가능 아이템 목록을 보려면 2번 기입” 을 출력시키고 입력받습니다.
                Console.Write("무기 목록을 보려면 1번, 사용 가능 아이템 목록을 보려면 2번 기입: ");

                int.TryParse(Console.ReadLine(), out var number);

                Console.WriteLine();

                // 유저 입력값에 따라 “???의 목록은 다음과 같습니다” 로 출력 수행.
                if (number == 1)
                {
                    Console.WriteLine("무기의 목록은 다음과 같습니다.");

                    Console.WriteLine();

                    ShowWeapons();
                }

                if (number == 2)
                {
                    Console.WriteLine("아이템의 목록은 다음과 같습니다.");

                    Console.WriteLine();

                    ShowItems();
                }
            }
        }

        public sealed class Item
        {
            private readonly string name;

            public string Name => name;

            private int count;

            public int Count => count;

            public Item(string name, int count)
            {
                this.name = name;

                this.count = count;
            }

            public override string ToString()
            {
                return $"{name} x {count}";
            }
        }

        public sealed class Weapon
        {
            private readonly string name;

            public string Name => name;

            private int damage;

            public int Damage => damage;

            public Weapon(string name, int damage)
            {
                this.name = name;

                this.damage = damage;
            }

            public override string ToString()
            {
                return $"{name} (공격력 {damage})";
            }
        }
    }
}