using System;

namespace Assignment1
{
    // 새로운 cs 파일을 만들고, Monster 클래스를 생성.
    internal sealed class Monster
    {
        // 문자열 몹 이름
        private string name;

        public string Name => name;

        // 정수형  몹 체력
        private int hp;

        public int HP => hp;

        // 정수형 몹 공격력
        private int damage;

        // 정수형 몹 방어력
        private int defense;

        // 정수형 몹 레벨
        private int level;

        // 기본 생성자: “Basic Monster"로 몬스터 이름을 설정하고, HP는 50, 공격력은 15, 방어력은 5, 레벨은 1로 설정.
        public Monster()
        {
            name = "Basic Monster";

            hp = 50;

            damage = 15;

            defense = 5;

            level = 1;
        }

        // 오버로딩 생성자: 이름, 체력, 공격력, 방어력, 레벨을 외부에서 세팅해 줄 수 있는 생성자도 하나 생성.
        public Monster(string name, int hp, int damage, int defense, int level)
        {
            this.name = name;

            this.hp = hp;

            this.damage = damage;

            this.defense = defense;

            this.level = level;
        }

        // TakeDamage
        // 반환은 없음.
        // 받은 피해를 체력에서 차감, 방어력은 피해를 경감시키는 역할.
        // 예를 들어, 인자로 넘어온 데미지가 40이고 방어력이 5이면 35 뎀지 입음.
        public void TakeDamage(int damage)
        {
            damage -= defense;

            if (damage < 0)
            {
                damage = 0;
            }

            hp -= damage;

            if (hp < 0)
            {
                hp = 0;
            }
        }

        // AttackHero
        // 반환은 없음.
        // 인자값으로 영웅 객체 hero 를 받아 몬스터가 영웅을 공격하도록 구현.
        // hero 속 메서드 TakeDamage를 호출, 인자값으로 몹 공격력 넘겨줌.
        public void AttackHero(Hero hero)
        {
            hero.TakeDamage(damage);
        }

        // DisplayInfo
        // 몬스터의 상태를 출력하는 함수.
        // 몬스터의 이름, 체력, 공격력, 방어력, 레벨을 출력.
        public void DisplayInfo()
        {
            Console.WriteLine($"이름: {name}");

            Console.WriteLine($"체력 {hp}");

            Console.WriteLine($"공격력: {damage}");

            Console.WriteLine($"방어력: {defense}");

            Console.WriteLine($"레벨: {level}");
        }
    }
}