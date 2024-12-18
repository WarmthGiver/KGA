/*
날짜: 24.12.16
이름: 이시온
*/
/*
### **과제 1) 필드 생성, 간단한 메서드**

- UsableItem이라는 클래스를 만들어 이름과 가격, 수량을 프라이빗 필드로 가지게 합니다. 외부와 소통이 가능하게끔 프로퍼티도 각각 만들어 줍니다
- UsableItem만 사용할 수 있는 특별한 메소드를 하나 자유롭게 만들어 주시기 바랍니다. 인자, 반환 형태 모두 개발자 마음대로 입니다.
- Player라는 클래스를 만들어, 해당 아이템이 자유롭게 추가될 수 있는 inventory 라는 필드를 추가해주시길 바랍니다. (배열 or List 중 본인 편한것으로)
- Player 클래스에, 유료결제 여부를 저장할 수 있는 필드를 하나 만듭니다. 해당 참거짓을 전환 가능한 프로퍼티 혹은 메소드도 제작 바랍니다

### **과제 2) 인덱서 or 메서드 활용, 방식 자유**

- Player에게 AddItem 이라는 메소드를 하나 만들겠습니다.
    - 인자값은 UsableItem 형 하나이고, 반환값은 없습니다.
    - 플레이어에게 있는 필드 중, 유료결제 여부가 참일 경우, 인벤토리에 아이템을 Add를 자유롭게 할 수 있고, 거짓일 경우 아이템을 최대 30개까지 저장 가능 하고, 초과로 저장하려고 시도하면 콘솔 출력을 통해 추가하지 않고 거부하는 기능을 만들어주시기 바랍니다.
- ShowInven 이라는 메서드도 만듭니다.
    - \t 와 같은 이스케이프 시퀀스를 활용하여 보유중인 아이템을 이쁘게 출력하는 메서드를 만들어 주시기 바랍니다.

### 과제 3) Item과는 사뭇 다른 Weapon 클래스

- Weapon 클래스 생성 후, 이름과 공격력 필드를 프라이빗으로 가지고 있게 합니다. 외부 소통이 가능하게끔 프로퍼티 또한 추가해줍니다.
- Weapon만 사용할 수 있는 특별한 메소드를 하나 자유롭게 만들어 주시기 바랍니다. 인자, 반환 형태 모두 개발자 마음대로 입니다.
*/

namespace Homework1_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {

        }

        // UsableItem이라는 클래스를 만들어,
        public sealed class UsableItem
        {
            // 이름과 가격, 수량을 프라이빗 필드로 가지게 합니다.
            private string name;

            // 외부와 소통이 가능하게끔 프로퍼티도 각각 만들어 줍니다.
            public string Name => name;

            private int count;

            public int Count => count;

            // UsableItem만 사용할 수 있는 특별한 메소드를 하나 자유롭게 만들어 주시기 바랍니다.인자, 반환 형태 모두 개발자 마음대로 입니다.
            public override string ToString()
            {
                return $"{name} x {count}";
            }
        }

        // Player라는 클래스를 만들어,
        public sealed class Player
        {
            // 해당 아이템이 자유롭게 추가될 수 있는 inventory 라는 필드를 추가해주시길 바랍니다. (배열 or List 중 본인 편한것으로)
            private List<UsableItem> inventory;

            // Player 클래스에, 유료결제 여부를 저장할 수 있는 필드를 하나 만듭니다.
            private bool isPayment;

            // 해당 참거짓을 전환 가능한 프로퍼티 혹은 메소드도 제작 바랍니다.
            public bool IsPayment
            {
                get => isPayment;

                set => isPayment = value;
            }

            // Player에게 AddItem 이라는 메소드를 하나 만들겠습니다.
            // 인자값은 UsableItem 형 하나이고, 반환값은 없습니다.
            public void AddItem(UsableItem item)
            {
                // 플레이어에게 있는 필드 중, 유료결제 여부가 참일 경우, 인벤토리에 아이템을 Add를 자유롭게 할 수 있고,
                // 거짓일 경우 아이템을 최대 30개까지 저장 가능 하고,
                if (isPayment == false && inventory.Count >= 30)
                {
                    // 초과로 저장하려고 시도하면 콘솔 출력을 통해 추가하지 않고 거부하는 기능을 만들어주시기 바랍니다.
                    Console.WriteLine("인벤토리가 꽉 찼습니다.");

                    return;
                }

                inventory.Add(item);
            }

            // ShowInven 이라는 메서드도 만듭니다.
            public void ShowInven()
            {
                // \t와 같은 이스케이프 시퀀스를 활용하여 보유중인 아이템을 이쁘게 출력하는 메서드를 만들어 주시기 바랍니다.
                foreach (var item in inventory)
                {
                    Console.WriteLine($"1. {item.ToString()}");
                }
            }
        }

        // Weapon 클래스 생성 후,
        public sealed class Weapon
        {
            // 이름과 공격력 필드를 프라이빗으로 가지고 있게 합니다.
            private string name;

            // 외부 소통이 가능하게끔 프로퍼티 또한 추가해줍니다.
            public string Name => name;

            private int damage;

            public int Damage => damage;

            // Weapon만 사용할 수 있는 특별한 메소드를 하나 자유롭게 만들어 주시기 바랍니다.인자, 반환 형태 모두 개발자 마음대로 입니다.
            public override string ToString()
            {
                return $"{name} (공격력 {damage})";
            }
        }
    }
}