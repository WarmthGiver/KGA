using System;

namespace Assignment1
{
    // 새로운 cs 파일을 만들고, Hero 클래스 생성.
    internal sealed class Hero
    {
        // 문자열 영웅의 이름
        private string name;

        // 정수형 영웅의 체력
        private int hp;

        public int HP => hp;

        // 정수형 영웅의 공격력
        private int damage;

        // 정수형 영웅의 방어력
        private int defense;

        // 기본 생성자: "Unknown Hero"로 영웅 이름을 설정하고, HP는 100, 공격력은 20, 방어력은 10으로 설정.
        public Hero()
        {
            name = "Unknown Hero";

            hp = 100;

            damage = 20;

            defense = 10;
        }

        // 오버로딩 생성자: 이름, 체력, 공격력, 방어력을 모두 외부에서 세팅해 줄 수 있는 생성자도 하나 생성.
        public Hero(string name, int hp, int damage, int defense)
        {
            this.name = name;

            this.hp = hp;

            this.damage = damage;

            this.defense = defense;
        }

        // TakeDamage
        // 피격을 나타내는 메서드.
        // 반환은 없음.인자값은 정수형 damage.
        // 받은 피해를 체력에서 차감, 방어력은 피해를 경감시키는 역할.
        // 예를 들어, 인자로 넘어온 데미지는 40, 방어력은 10이면 총 30 데미지 받음.
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

        // AttackMob
        // 몬스터 공격하는 메서드
        // 반환 없음.인자값은 아래 만들 Monster형 mob.
        // cw 로 “몹 이름을 공격!” 출력.
        // mob의 TakeDamage 메서드 호출하되, 인자로 hero의 공격력 넘김.
        public void AttackMob(Monster mob)
        {
            Console.WriteLine($"{mob.Name}을 공격!");

            mob.TakeDamage(damage);
        }

        // DisplayInfo
        // 영웅의 상태를 출력하는 함수.
        // cw로 영웅 속 다양한 요소들을 본인 취향에 맞게 자유롭게 출력하는 기능.
        public void DisplayInfo()
        {
            Console.WriteLine($"이름: {name}");

            Console.WriteLine($"체력 {hp}");

            Console.WriteLine($"공격력: {damage}");

            Console.WriteLine($"방어력: {defense}");
        }
    }
}