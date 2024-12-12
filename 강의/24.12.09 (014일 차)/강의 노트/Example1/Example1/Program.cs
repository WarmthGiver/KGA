/*
날짜: 24.12.09
이름: 이시온
*/

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ClassExample1();

            //ClassExample2();

            //GCExample1();

            Example2();
        }

        #region 클래스(Class)

        // 클래스(Class)
        // 구조체(Struct)와 비슷하지만 클래스는 참조타입, 구조체는 값타입.

        // 스택(Stack) 영역
        // 매개변수, 지역변수

        // 힙(Heap) 영역
        // 
        private class Car
        {
            // 멤버 변수
            // 
            public readonly string name;

            // 정보 은닉(Information Hiding)
            // 외부에 공개될 필요 없는 멤버 변수를 숨김.
            // 외부에서 직접 접근하지 못하도록 하고 메서드를 통해서만 조작하게 하는 것.
            private int carNumber;

            // 자동 구현 프로퍼티
            // 
            public int CarNumber
            {
                get
                {
                    return carNumber;
                }
                set
                {
                    carNumber = value;
                }
            }

            public Car() { }

            public Car(string name)
            {
                this.name = name;
            }

            // 메소드(Method)
            // 클래스 내의 함수 등의 기능.
            //

            // Getter/Setter 함수
            // public 멤버 함수를 통해 private 멤버 변수를 읽고 쓸 수 있음.
            public int GetCarNumber()
            {
                return carNumber;
            }
            public void SetCarNumber(int value)
            {
                carNumber = value;
            }
        }

        #endregion

        #region 클래스 예제 1

        private static void ClassExample1()
        {
            Car car1 = new("Ferrari");
            Console.WriteLine($"car1 = new(\"{car1.name}\")");
            Console.WriteLine();

            // car2과 car1는 같은 객체를 가리킴.
            Car car2 = car1;
            Console.WriteLine($"car2 = car1");
            Console.WriteLine();

            Console.WriteLine($"car2.name: {car2.name}");
            Console.WriteLine();

            // 이제 car1과 car2는 서로 다른 객체를 가리킴.
            car1 = new("Porsche");
            Console.WriteLine($"car1 = new(\"{car1.name}\")");
            Console.WriteLine();

            Console.WriteLine($"car1.name: {car1.name}");
            Console.WriteLine($"car2.name: {car2.name}");
        }

        #endregion

        #region 클래스 예제 2

        private static void ClassExample2()
        {
            Car car1 = new();

            // carNumber는 private이므로 접근 불가.
            //car1.carNumber = 1;
            //Console.WriteLine($"Car Number: {car1.carNumber}");

            // Getter/Setter 함수로 접근
            car1.SetCarNumber(1);
            Console.WriteLine($"Car Number: {car1.GetCarNumber()}");

            // 프로퍼티로 접근
            car1.CarNumber = 2;
            Console.WriteLine($"Car Number: {car1.CarNumber}");
        }

        #endregion

        #region GC 예제 1

        private static void GCExample1()
        {
            // 가비지 콜렉터(GC: Garbage Collector)
            // 더 이상 참조되지 않는 메모리 공간을 자동으로 정리해주는 기법.
            // C#에서는 기본적으로 GC를 사용함.

            Car car1 = new();

            // car1이 이전에 가리키던 메모리는 GC의 대상이 됨.
            car1 = new();

            Car car2 = car1;

            // car2가 car1이 이전에 가리키던 메모리를 car2가 가리키고 있기 때문에 GC의 대상이 되지 않음.
            car1 = new();
        }

        #endregion

        #region 

        /*속성
        이름 : 문자열
        등급 : [Rare, Epic, Legendary] 세가지중 하나만 가질 수 있음
        레벨 : 1~30의 정수
        속성 : [speed, critical, specialize] 세가지중 하나만 가질 수 있음
        스킬 : [manaRestore, healthRestore, attSpeedUp, none]

        메소드 or 프로퍼티
        - 펫 이름은 열람도, 수정도 가능
        - 펫 등급을 보여주는 기능 보유. 희귀면 파랑색으로 Rare 출력, 에픽은 보라로 Epic, 
        전설은 노랑글씨로 Legendary 출력하는 기능
        - 레벨은 열람만 가능, 레벨을 1 올린다는 메소드가 하나 존재. 30 넘어가면 30 고정
        - 속성을 열람 및 설정 가능함. 단, 속성에 부여 가능한 세가지중 하나로만 가능
        - 랜덤 스킬 부여 라는 메소드 보유. 펫 등급이 legendary가 아니면 none이 자동 부여,
        전설이면 none을 제외한 스킬 중 랜덤하게 하나가 배정됨
        - 스킬을 보여주는 메서드도 있음
        */

        public abstract class Item
        {
            protected string name;

            protected Rarity rarity;

            private byte level;
            public byte Level => level;

            public Property property;

            private Skill skill;

            private Random random = new();

            protected Item(string name,  Rarity rarity, byte level)
            {
                this.name = name;

                this.rarity = rarity;

                this.level = level;

                SetSkillRandom();
            }

            public void ShowRarity()
            {
                Console.Write("등급: ");
                switch (rarity)
                {
                    case Rarity.Rare:

                        Console.ForegroundColor = ConsoleColor.Blue;

                        break;

                    case Rarity.Epic:

                        Console.ForegroundColor = ConsoleColor.Magenta;

                        break;

                    case Rarity.Legendary:

                        Console.ForegroundColor = ConsoleColor.Yellow;

                        break;
                }
                Console.WriteLine($"{rarity}");
                Console.ResetColor();
            }

            public void LevelUp()
            {
                Console.WriteLine("레벨업!");
                Console.WriteLine();

                if (level < 30)
                {
                    ++level;
                }
            }

            public void SetSkillRandom()
            {
                Console.WriteLine("스킬 랜덤 설정");
                Console.WriteLine();

                if (rarity != Rarity.Legendary)
                {
                    skill = Skill.none;
                }
                else
                {
                    skill = (Skill)random.Next(0, (int)Skill.none);
                }
            }

            public void ShowSkill()
            {
                Console.WriteLine($"스킬: {skill}");
            }

            public override string ToString()
            {
                return
                    $"이름: {name}\n" +
                    $"등급: {rarity}\n" +
                    $"레벨: {level}\n" +
                    $"속성: {property}\n" +
                    $"스킬: {skill}";
            }

            public enum Rarity
            {
                Rare,
                Epic,
                Legendary,
            }

            public enum Property
            {
                Speed,
                Critical,
                Specialize,
            }

            public enum Skill
            {
                manaRestore,
                healthRestore,
                attSpeedUp,
                none,
            }
        }

        public class Pet : Item
        {
            public string Name
            {
                get => name;
                set => name = value;
            }

            public Pet(string name, Rarity rarity, byte level) : base(name, rarity, level) { }
        }

        public static void Example2()
        {
            Pet pet = new("Doge", Item.Rarity.Legendary, 30);

            Console.WriteLine(pet.ToString());
            Console.WriteLine();

            pet.Name = "Doggo";
            pet.property = Item.Property.Specialize;
            pet.LevelUp();
            pet.SetSkillRandom();

            Console.WriteLine(pet.ToString());
            Console.WriteLine();

            pet.ShowRarity();
            pet.ShowSkill();
        }

        #endregion
    }
}