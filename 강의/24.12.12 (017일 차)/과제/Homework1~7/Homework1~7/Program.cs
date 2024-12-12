/*
날짜: 24.12.12
이름: 이시온
*/
/*
### **과제 1)**

Trainer라는 클래스를 하나 만들겠습니다.
해당 클래스는 필드로 획득뱃지 갯수를 저장하는 정수형,
이름을 나타내는 문자열 필드,
그리고 스타팅몬스터를 기입할 수 있는 문자열 필드를 보유하게 합니다.
*/
/*
### **과제 2)**

트레이너를 생성할 때, 이름과 스타팅몬스터의 이름을 문자열로 입력받아 객체를 만드는 생성자를 하나 만들어 주세요.
또한 스타팅몬스터를 바꿀 수 있는 메소드도 하나 만들어주시기 바랍니다. (방식 자유)
*/
/*
### **과제 3)**

클래스 외부에 열거형 자료형 MobType를 하나 만들고
요소로는 Normal, Fire, Water, Grass 를 입력하여 주시기 바랍니다.

그 후, Monster라는 클래스를 새로 하나 만들고,
해당 클래스의 필드로는 정수형 레벨,
열거형 몹타입,
그리고 문자열 이름을 넣어서 만들어 주시기 바랍니다.
*/
/*
### **과제 4)**

방금 만들어진 Monster 클래스에 인자값을 요구하지 않는 기본 생성자를 만들고,
이렇게 만들어 졌을 경우, 몹의 타입은 Normal, 이름은 "", 레벨은 1로 설정되게 코드를 작성하여 주시기 바랍니다.
두번째 생성자는, 인자값으로 몹의 타입, 레벨, 몹의 이름을 받아 생성과 동시에 값을 세팅하는 생성자도 만들어 주시기 바랍니다.
*/
/*
### **과제 5)**

Trainer 클래스의 필드에, 여러 몬스터를 담을 수 있는 배열을 만들어 주시기 바랍니다.
그 후, 과제2에서 만든 생성자 내부에 몬스터 배열을 6개 담을 수 있게 동적할당 시키는 코드를 작성하여 주시기 바랍니다.
*/
/*
### **과제 6)**

Trainer에게 생성자를 하나 더 추가하여 줍니다

- 생성자 오버로딩을 통해, 인자값으로 몬스터를 받습니다
- 트레이너가 가진 몬스터배열을 6개 담을 수 있게 동적할당 시킵니다
- 만들어진 몹 배열의 0번째 인덱스에, 방금 건네받은 몹으로 담아줍니다
*/
/*
### 과제 7)

트레이너에게 ShowFirstMob이라는 메소드를 만들어,
콘솔창에는 배열의 0번째 몹의 레벨과 이름이 출력되는 내용을 기입하여 주시기 바랍니다.
*/

using System;

namespace Homework1_7
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {

        }
    }

    // Trainer라는 클래스를 하나 만들겠습니다.
    public sealed class Trainer
    {
        // 해당 클래스는 필드로 획득뱃지 갯수를 저장하는 정수형,
        private int badgeCount = 0;

        // 이름을 나타내는 문자열 필드,
        private string name;

        // 그리고 스타팅몬스터를 기입할 수 있는 문자열 필드를 보유하게 합니다.
        private string startingMonster;

        // Trainer 클래스의 필드에, 여러 몬스터를 담을 수 있는 배열을 만들어 주시기 바랍니다.
        private Monster[] monsters;

        // 트레이너를 생성할 때, 이름과 스타팅몬스터의 이름을 문자열로 입력받아 객체를 만드는 생성자를 하나 만들어 주세요.
        public Trainer(string name, string startingMonster)
        {
            this.name = name;

            this.startingMonster = startingMonster;

            // 그 후, 과제2에서 만든 생성자 내부에 몬스터 배열을 6개 담을 수 있게 동적할당 시키는 코드를 작성하여 주시기 바랍니다.
            monsters = new Monster[6];
        }

        // Trainer에게 생성자를 하나 더 추가하여 줍니다.
        // 생성자 오버로딩을 통해, 인자값으로 몬스터를 받습니다.
        // 트레이너가 가진 몬스터배열을 6개 담을 수 있게 동적할당 시킵니다.
        public Trainer(string name, Monster monster) : this(name, monster.Name)
        {
            // 만들어진 몹 배열의 0번째 인덱스에, 방금 건네받은 몹으로 담아줍니다.
            monsters[0] = monster;
        }

        // 또한 스타팅몬스터를 바꿀 수 있는 메소드도 하나 만들어주시기 바랍니다. (방식 자유)
        public void ChangeStartingMonster(string value)
        {
            startingMonster = value;
        }

        // 트레이너에게 ShowFirstMob이라는 메소드를 만들어,
        public void ShowFirstMob()
        {
            // 콘솔창에는 배열의 0번째 몹의 레벨과 이름이 출력되는 내용을 기입하여 주시기 바랍니다.
            Console.WriteLine("첫 번째 몬스터:");

            Console.WriteLine($"레벨: {monsters[0].Level}");

            Console.WriteLine($"이름: {monsters[0].Name}");
        }
    }

    // 클래스 외부에 열거형 자료형 MobType를 하나 만들고
    public enum MobType
    {
        // 요소로는 Normal, Fire, Water, Grass를 입력하여 주시기 바랍니다.
        Normal,

        Fire,

        Water,

        Grass,
    }

    // 그 후, Monster라는 클래스를 새로 하나 만들고,
    public sealed class Monster
    {
        // 해당 클래스의 필드로는 정수형 레벨,
        private int level;

        public int Level => level;

        // 열거형 몹타입,
        private MobType type;

        // 그리고 문자열 이름을 넣어서 만들어 주시기 바랍니다.
        private string name;

        public string Name => name;

        // 방금 만들어진 Monster 클래스에 인자값을 요구하지 않는 기본 생성자를 만들고,
        public Monster()
        {
            // 이렇게 만들어 졌을 경우, 몹의 타입은 Normal, 이름은 "", 레벨은 1로 설정되게 코드를 작성하여 주시기 바랍니다.
            level = 0;

            type = MobType.Normal;

            name = "";
        }

        // 두번째 생성자는, 인자값으로 몹의 타입, 레벨, 몹의 이름을 받아 생성과 동시에 값을 세팅하는 생성자도 만들어 주시기 바랍니다.
        public Monster(int level, MobType type, string name)
        {
            this.level = level;

            this.type = type;

            this.name = name;
        }
    }
}