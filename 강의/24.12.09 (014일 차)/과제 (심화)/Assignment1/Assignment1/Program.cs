/*
날짜: 24.12.09
이름: 이시온

**과제 1) 클래스 생성 실습**

- 새로운 cs파일을 하나 생성 합니다. 그 속에 Car라는 클래스를 만든 후,
    - 필드로 문자열 차이름,
    - 정수형 자동차넘버,
    - 정수형 자동차체력

**과제 2) 클래스 생성 실습**

- 새로 cs파일을 생성 후에 Monster라는 클래스를 만든 후,
    - 필드로 정수형 공력력,
    - 정수형 HP를 가지고 있게 합니다.
    - 필드로 위치와 관련된 구조체를 하나 들고 있게 합니다.
        - 구조체 설계도 이름은 Vector2, 속에는 int x, int y 두 개가 있습니다
    - 해당 필드를 외부에서 접근할 수 있도록 프로퍼티를 각각 만들되, 공격력, HP에 음수를 세팅할 경우, 콘솔에 음수로 세팅 할 수 없다고 출력하며 대신 해당 필드를 0으로 만들도록 만들어 주세요
    - 몬스터 속에 AttackCar 라는 void형 함수를 하나 만들고, 인자값으로 Car형을 받습니다. 해당 함수가 실행될 경우, 몬스터가 가진 공격력으로, Car 객체의 체력을 깎는 코드를 작성하시길 바랍니다. 이후, “{공격력} 만큼의 데미지를 {차이름} 에 주었습니다” 도 출력합니다.

**과제 3) 테스트**

- 메인으로 와서 Car 객체와(1번에서 만들었던), Monster(2번에서 만든) 객체를 하나 만듭니다.
- 위의 몬스터를 전부 만들었으면 메인에서 몬스터 객체를 하나 만들고 공격력에는 20을 세팅해준 후 만들어진 자동차와 함께 Attack함수를 호출해보자
- 자동차의 체력도 출력해서 깎였는지 확인해보세요

---

### **심화 과제 (서서히 문제가 불친절해집니다!)**

- 위 몬스터 클래스를 지우지 말고 추가로 별도의 cs를 새로 만들고 Item이라는 클래스를 따로 제작.
    - 필드형으로는 ???형 아이템 이름
    - ??형 아이템타입
    - ??? 형 가격

- 이어서 Inventory라는 클래스를 새로운  cs 시트에 제작,
    - 필드로 아이템 배열을 가지게 함
    - 추가적인 필드가 필요하면 생성
    
    - 이 클래스 내에 네가지 메소드 제작.
    - 첫번째 메서드명은 CreateInvenBySize에 인자값은 정수형 하나. 넘어온 인자값에 따라 아이템 배열을 할당해주고, 인자값만큼 인벤토리가 만들어졌다고 출력하는 기능 제작.
    - 두번째 메서드로는 반환값으로는 bool형, 함수명은 isInvenCreated, 함수 내용은 아이템배열이 0보다 작거나 null일 경우 false, 존재한다면 true반환
    - 세번째 함수는 GetItemByIndex, 리턴값은 아이템 함수 구현사항으로는 아이템 배열 중, 해당 인자값 위치의 아이템 반환하거나 비어있을 경우, null을 반환함과 동시에 비어있음 출력, 인자값은 정수형 인덱스,
    - 마지막 함수는 SetItemByIndex, 반환형은 없고, 인자값은 인덱스와 Item형 하나를 받는 함수 제작

- Player라는 클래스를 새로운 cs에 만듭니다
    - 필드로 문자열형 이름, 정수형 HP, 정수형 공격력, 구조체 좌표(short형 x와 short형 y 두가지를 보유한 구조체), Inventory클래스로 만든 객체 하나를 보유하게 만듦.
    - MakeInven의 이름으로 인벤토리를 뉴할당시키는 함수 하나 제작, 프로퍼티를 통해 인벤토리를 get하는 기능 제작

- main에서 플레이어 객체를 하나 만든 후, 플레이어의 함수를 통해 인벤토리를 활성화 하자. 다음엔 플레이어 속의 프로퍼티 인벤을 통해 인벤토리 클래스 속의 CreateInvenBySize함수를 통해 원하는 만큼의 아이템배열을 만든 후, 본인이 원하는 특정 위치에 아이템을 하나 만들어 넣도록 하자. 플레이어 속 혹은 인벤토리 속 다양한 함수를 직접 확인해 볼 수 있는 코드들을 메인에 적도록 하자.

- 위에서 만든 Player 클래스 속의 hp와 데미지를 프로퍼티로 바꾸자. 메인을 싹 비우고, 플레이어 객체 하나와 몬스터 객체를 하나 만든 후, 몬스터에는 체력 100, 공격력 10을 넣어주자. 플레이어는 체력200, 공격력 20을 주어준 후, 각각의 HP와 공격을 get과 set을 활용하여 플레이어가 본인의 공격력을 활용해 몹을 한대 때려서 체력을 깎는 것을 출력하여보자. 객체를 만든 후 모든 공격과 체력이 닳는 과정은 메인서 콘솔로 출력해도 좋다
*/

using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 메인으로 와서 Car 객체와,
            Car car = new();
            car.Name = "포르쉐 911";
            car.HP = 30;

            // Monster(2번에서 만든) 객체를 하나 만듭니다.
            Monster monster = new();
            // 위의 몬스터를 전부 만들었으면 공격력에는 20을 세팅해준 후,
            monster.Damage = 20;

            // 만들어진 자동차와 함께 Attack함수를 호출해보자.
            monster.AttackCar(car);
            // 자동차의 체력도 출력해서 깎였는지 확인해보세요.
            Console.WriteLine($"{car.Name} 체력: {car.HP}");
            monster.AttackCar(car);
            Console.WriteLine($"{car.Name} 체력: {car.HP}");

            // main에서 플레이어 객체를 하나 만든 후
            Player player = new Player();
            // 플레이어의 함수를 통해 인벤토리를 활성화 하자.
            player.MakeInven();
            // 다음엔 플레이어 속의 프로퍼티 인벤을 통해 인벤토리 클래스 속의 CreateInvenBySize함수를 통해 원하는 만큼의 아이템배열을 만든 후,
            player.Inventory.CreateInvenBySize(3);
            // 본인이 원하는 특정 위치에 아이템을 하나 만들어 넣도록 하자.
            Item item = new Item();
            item.Name = "후루츠 대거";
            item.Type = ItemType.무기;
            item.Price = 100;

            player.Inventory.SetItemByIndex(0, item);

            item = new Item();
            item.Name = "냄뚜";
            item.Type = ItemType.방패;
            item.Price = 400;

            player.Inventory.SetItemByIndex(1, item);

            item = new Item();
            item.Name = "빨간 포션";
            item.Type = ItemType.소모품;
            item.Price = 5;
            
            player.Inventory.SetItemByIndex(2, item);

            // 플레이어 속 혹은 인벤토리 속 다양한 함수를 직접 확인해 볼 수 있는 코드들을 메인에 적도록 하자.

            for (int i = 0; i < player.Inventory.items.Length; ++i)
            {
                Console.WriteLine();
                Console.WriteLine($"{i + 1}번 아이템:");
                Console.WriteLine();
                Console.WriteLine(player.Inventory.GetItemByIndex(i).ToString());
            }
        }
    }
}