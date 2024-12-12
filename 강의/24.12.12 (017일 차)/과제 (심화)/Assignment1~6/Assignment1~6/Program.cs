/*
날짜: 24.12.12
이름: 이시온
*/
/*
### **심화 과제 1**

바로 위에서, Trainer라는 클래스를 만들었습니다.
해당 구현 과제를 추상 클래스를 활용하여 리팩토링(다시 만들기)를 진행하려 합니다.
다음 구현사항에 맞추어 Trainer클래스를 완성시켜 주시기 바랍니다.

Monster라는 **추상 클래스**를 새로 하나 만들고,
해당 클래스의 필드로는 정수형 레벨, 열거형 몹타입, 그리고 문자열 이름을 넣어서 만들어 주시기 바랍니다.
Monster 추상 클래스에 BaseAttack이라는 abstract 메소드도 추가하여 주시기 바랍니다.
*/
/*
### **심화 과제 2**

이 Monster 클래스를 상속받는 Pikachu, Squirtle, Bulbasaur, Charmander 네 가지의 클래스를 만들어 주시기 바랍니다.
Pikachu의 BaseAttack에는 '전광석화', Squirtle는 '물총발사', Bulbasaur는 '덩굴채찍', Charmander는 '화염방사' 를 콘솔에 출력하는 기능을 각각 제작하여 주시기 바랍니다.
각각 몬스터들의 생성자에는 인자값으로 이름과 레벨을 받을 수 있게 하고, 몹타입은 본인 취향 적절한 타입을 기입하여 주시기 바랍니다.
*/
/*
### **심화 과제 3**

Trainer 클래스에 6개의 몬스터형을 담을 수 있는 배열이 있을겁니다.
트레이너 생성자에는 자동으로 피카츄를 배열의 첫 번째에 담기게 하는 코드를 작성하여 주시기 바랍니다. 
*/
/*
### **심화 과제 4**

Trainer 클래스의 메소드로는,
몬스터를 인자값으로 받아 추가하는 기능,
만약 6마리를 초과해서 추가하려 하면, 추가하지 않고 경고문을 내는 메소드를 하나 제작해주시기 바랍니다.
이를 제작하기 위해 추가 필드가 필요하다면 추가 작성하시길 바랍니다.
*/
/*
### **심화 과제 5**

 배열 속 보유중인 모든 몹들이 가진 BaseAttack을 전부 실행하는 AllAttack이라는 메소드를 작성하세요. 
*/
/*
### **심화 과제 6**

메인에서 Trainer를 하나 만든 후,
Trainer 객체에 Charmander 한마리를 이름은 '파이리', 레벨은 5로 하여 추가하는 코드를 작성하세요.
Trainer의 AllAttack 메소드를 호출하여 트레이너가 가진 모든 몹의 공격이 콘솔에 출력되게 하세요.
*/

namespace Assignment1_6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 메인에서 Trainer를 하나 만든 후,
            Trainer trainer = new Trainer("한지우");

            // Trainer 객체에 Charmander 한마리를 이름은 '파이리', 레벨은 5로 하여 추가하는 코드를 작성하세요.
            trainer.AddMonster(new Charmander("파이리", 5));

            // Trainer의 AllAttack 메소드를 호출하여 트레이너가 가진 모든 몹의 공격이 콘솔에 출력되게 하세요.
            trainer.AllAttack();
        }
    }

    public sealed class Trainer
    {
        private int badgeCount = 0;

        private string name;

        private string startingMonster;

        private Monster[] monsters;

        private byte monstersCount = 1;

        public Trainer(string name)
        {
            this.name = name;

            this.startingMonster = "Pikachu";

            // Trainer 클래스에 6개의 몬스터형을 담을 수 있는 배열이 있을겁니다.
            monsters = new Monster[6];

            // 트레이너 생성자에는 자동으로 피카츄를 배열의 첫 번째에 담기게 하는 코드를 작성하여 주시기 바랍니다.
            monsters[0] = new Pikachu("Pikachu", 1);
        }

        public void ChangeStartingMonster(string value)
        {
            startingMonster = value;
        }

        public void ShowFirstMob()
        {
            Console.WriteLine("첫 번째 몬스터:");

            Console.WriteLine($"레벨: {monsters[0].Level}");

            Console.WriteLine($"이름: {monsters[0].Name}");
        }

        // Trainer 클래스의 메소드로는, 몬스터를 인자값으로 받아 추가하는 기능,
        public void AddMonster(Monster monster)
        {
            // 만약 6마리를 초과해서 추가하려 하면,
            if (monstersCount >= 6)
            {
                // 추가하지 않고 경고문을 내는 메소드를 하나 제작해주시기 바랍니다.
                Console.WriteLine("파티가 꽉 찼습니다!");
                
                return;
            }

            monsters[monstersCount++] = monster;
        }

        // 배열 속 보유중인 모든 몹들이 가진 BaseAttack을 전부 실행하는 AllAttack이라는 메소드를 작성하세요.
        public void AllAttack()
        {
            for (int i = 0; i < monstersCount; ++i)
            {
                monsters[i].BaseAttack();
            }
        }
    }
    public enum MobType
    {
        Normal,

        Fire,

        Water,

        Grass,

        Electric,
    }

    // Monster라는 추상 클래스를 새로 하나 만들고,
    public abstract class Monster
    {
        // 해당 클래스의 필드로는 정수형 레벨, 열거형 몹타입, 그리고 문자열 이름을 넣어서 만들어 주시기 바랍니다.
        private int level;

        public int Level => level;

        private MobType type;

        private string name;

        public string Name => name;

        public Monster()
        {
            level = 0;

            type = MobType.Normal;

            name = "";
        }

        public Monster(int level, MobType type, string name)
        {
            this.level = level;

            this.type = type;

            this.name = name;
        }

        // Monster 추상 클래스에 BaseAttack이라는 abstract 메소드도 추가하여 주시기 바랍니다.
        public abstract void BaseAttack();
    }

    // 이 Monster 클래스를 상속받는 Pikachu, Squirtle, Bulbasaur, Charmander 네 가지의 클래스를 만들어 주시기 바랍니다.

    public sealed class Pikachu : Monster
    {
        // 각각 몬스터들의 생성자에는 인자값으로 이름과 레벨을 받을 수 있게 하고, 몹타입은 본인 취향 적절한 타입을 기입하여 주시기 바랍니다.
        public Pikachu(string name, int level) : base(level, MobType.Electric, name) { }

        // Pikachu의 BaseAttack에는 '전광석화',

        public override void BaseAttack()
        {
            Console.WriteLine("전광석화");
        }
    }

    public sealed class Squirtle : Monster
    {
        public Squirtle(string name, int level) : base(level, MobType.Water, name) { }

        // Squirtle는 '물총발사',

        public override void BaseAttack()
        {
            Console.WriteLine("물총발사");
        }
    }

    public sealed class Bulbasaur : Monster
    {
        public Bulbasaur(string name, int level) : base(level, MobType.Grass, name) { }

        // Bulbasaur는 '덩굴채찍',

        public override void BaseAttack()
        {
            Console.WriteLine("덩굴채찍");
        }
    }

    public sealed class Charmander : Monster
    {
        public Charmander(string name, int level) : base(level, MobType.Fire, name) { }

        // Charmander는 '화염방사' 를 콘솔에 출력하는 기능을 각각 제작하여 주시기 바랍니다.

        public override void BaseAttack()
        {
            Console.WriteLine("화염방사");
        }
    }
}