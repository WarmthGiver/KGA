using System;

namespace Assignment1
{
    // Monster라는 클래스를 만든 후,
    public class Monster
    {
        // 해당 필드를 외부에서 접근할 수 있도록 프로퍼티를 각각 만들되, 공격력, HP에 음수를 세팅할 경우, 콘솔에 음수로 세팅 할 수 없다고 출력하며 대신 해당 필드를 0으로 만들도록 만들어 주세요

        // 필드로 정수형 공력력,
        public int Damage { get; set; }

        // 정수형 HP를 가지고 있게 합니다.
        private int hp;
        public int HP
        {
            get => hp;
            set
            {
                hp = value;

                if (hp < 0)
                {
                    Console.WriteLine("체력을 음수로 세팅 할 수 없습니다.");

                    hp = 0;
                }
            }
        }

        // 필드로 위치와 관련된 구조체를 하나 들고 있게 합니다.
        public Vector2 Position { get; set; }

        // 몬스터 속에 AttackCar 라는 void형 함수를 하나 만들고, 인자값으로 Car형을 받습니다. 해당 함수가 실행될 경우, 몬스터가 가진 공격력으로, Car 객체의 체력을 깎는 코드를 작성하시길 바랍니다. 이후, “{공격력} 만큼의 데미지를 {차이름} 에 주었습니다” 도 출력합니다.
        public void AttackCar(Car car)
        {
            car.HP -= Damage;

            Console.WriteLine($"{Damage}만큼의 데미지를 {car.Name}에 주었습니다");
        }

        // 구조체 설계도 이름은 Vector2, 속에는 int x, int y 두 개가 있습니다
        public struct Vector2
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}