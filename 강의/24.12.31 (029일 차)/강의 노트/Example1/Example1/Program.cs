/*
날짜: 24.12.31
이름: 이시온
*/

using System;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

        }

        //객체지향 SOLID 원칙 +DRY, YAGNI, KISS
        //저흰 콘솔 프로젝트를 통해 객체지향 4대 특징으로 추상화, 상속, 다형성, 캡슐화를 직접 체험해보았습니다.이젠 한 단계 더 나아가 좋은 설계의 기준을 나타내는 다섯 가지 원칙인 SOLID 원칙에 대해 알아보도록 하겠습니다
        //SOLID: 단단한, 고체, 견고한

        //단일 책임 원칙(Single Responsibility Principle, SRP)
        //클래스는 단 하나의 책임만 가져야 한다.

        //안 좋은 예:

        //클래스가 보고서 생성과 파일 저장 두 가지 책임을 가짐.
        public class Report
        {
            public void GenerateReport()
            {

            }

            public void SaveToFile(string filePath)
            {

            }
        }

        //좋은 예:

        //리포트만 담당
        public class Report
        {
            public void GenerateReport()
            {

            }
        }

        //저장만 담당
        public class ReportSaver
        {
            public void SaveToFile(string filePath, Report report)
            {

            }
        }
​
        //개방-폐쇄 원칙(Open/Closed Principle, OCP)
        //설명: 확장에는 열려 있어야 하고, 수정에는 닫혀 있어야 한다.

        //안 좋은 예:

        public class Shape
        {
            public string Type;
        }

        public class AreaCalculator
        {
            public double CalculateArea(Shape shape)
            {
                // 새로운 도형을 추가하면 CalculateArea 메서드를 수정해야 함.

                if (shape.Type == "Circle")
                {

                }

                else if (shape.Type == "Rectangle")
                {

                }

                return 0;
            }
        }
​
        //좋은 예:

        public abstract class Shape
        {
            public abstract double CalculateArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public override double CalculateArea() => Math.PI * Radius * Radius;
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }

            public double Height { get; set; }

            public override double CalculateArea() => Width * Height;
        }
​
        //다시 말해, 새로운 클래스는 쉽게 추가할 수 있고, 추가 되더라도 기존 코드들을 수정할 필요 없게 만들자는 뜻

        //3. 리스코프 치환 원칙(Liskov Substitution Principle, LSP)
        //설명: 자식 클래스는 부모 클래스를 대체할 수 있어야 한다.
        //안 좋은 예:

public class Character
        {
            public virtual void Move()
            {
                Console.WriteLine("기본 움직임");
            }
        }

        public class Player : Character
        {
            public override void Move()
            {
                Console.WriteLine("WASD로 이동");
            }
        }

        public class Enemy : Character
        {
            public override void Move()
            {
                throw new NotImplementedException("적 움직임은 없어서 안만듦");
            }
        }
​
//문제: 다형성 쓰면 터짐
//Character character = new Enemy();
//        character.Move(); // 당연히 터짐
​
//좋은 예:
public class Character
        {
            public virtual void Move()
            {
                Console.WriteLine("기본 움직임");
            }
        }

        public class Player : Character
        {
            public override void Move()
            {
                Console.WriteLine("WASD로 이동");
            }
        }

        public class Enemy : Character
        {
            public override void Move()
            {
                Console.WriteLine("플레이어 찾는 순찰 시행");
            }
        }
​
//부모 클래스에서 정의된 모든 동작은 자식클래스에서도 일관성 있게 작동해야 함
//4. 인터페이스 분리 원칙(Interface Segregation Principle, ISP)
//설명: 클라이언트가 사용하지 않는 메서드에 의존하지 않아야 한다.
//안 좋은 예:
public interface IWorker
        {
            void Work();
            void Eat();
        }

        public class Robot : IWorker
        {
            public void Work() { }
            public void Eat() { throw new NotImplementedException(); }
        }
​
//문제: Robot은 Eat 메서드를 사용할 필요가 없음.
//좋은 예:
public interface IWorkable
        {
            void Work();
        }

        //인터페이스가 많아도 좋으니 기능별로 분리
        public interface IFeedable
        {
            void Eat();
        }

        public class Human : IWorkable, IFeedable
        {
            public void Work() { }
            public void Eat() { }
        }

        public class Robot : IWorkable
        {
            public void Work() { }
        }
​
//5. 의존성 역전 원칙(Dependency Inversion Principle, DIP)
//설명: 고수준 모듈이 저수준 모듈에 의존해서는 안 된다.둘 다 추상화에 의존해야 한다.
//안 좋은 예:
public class Player
        {
            private Sword sword = new Sword(); // 구체적인 클래스에 의존

            public void Attack()
            {
                sword.Swing(); // 직접 호출
            }
        }

        public class Sword
        {
            public void Swing()
            {
                Console.WriteLine("칼 관련 동작");
            }
        }

        public class Game
        {
            static void Main(string[] args)
            {
                Player player = new Player();
                player.Attack();
            }
        }

​
//플레이어 클래스가 Sword 클래스에 강하게 의존
//다른 무기를 추가하려면, Player를 수정해야 함
//좋은 예:
//인터페이스로 무기를 분리함
public interface IWeapon
        {
            void Use();
        }

        public class Sword : IWeapon
        {
            public void Use()
            {
                Console.WriteLine("칼 관련 동작");
            }
        }

        public class Bow : IWeapon
        {
            public void Use()
            {
                Console.WriteLine("활 관련 동작");
            }
        }

        public class Player
        {
            private IWeapon weapon;

            public Player(IWeapon weapon) // 의존성 주입
            {
                this.weapon = weapon;
            }

            public void Attack()
            {
                weapon.Use(); // 추상화된 메서드 호출
            }
        }
    }
}