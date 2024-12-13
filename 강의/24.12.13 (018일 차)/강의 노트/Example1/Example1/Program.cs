/*
날짜: 24.12.13
이름: 이시온
*/

using System;

namespace Example1
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            InterfaceExample1();
        }

        #region 인터페이스(Interface) 예제

        // 인터페이스(Interface)
        // 추상 클래스(Abtract Class)와 같이 상속만 가능한 집합체.
        // 구조체와 클래스에 상속할 수 있으며 클래스와 여러 인터페이스를 같이 상속 가능.
        // 필드는 구현할 수 없고 메서드만 구현할 수 있음.

        public interface IWalkable
        {
            public void Walk();
        }

        public interface ICryable
        {
            public void Cry();
        }

        public abstract class Animal : IWalkable, ICryable
        {
            public void Walk()
            {
                Console.WriteLine("이동");
            }

            public abstract void Cry();
        }

        public class Dog : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("Woof!");
            }
        }

        public class Cat : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("Meow!");
            }
        }

        private static void InterfaceExample1()
        {
            IWalkable walkable1 = new Dog();

            IWalkable walkable2 = new Cat();

            walkable1.Walk();

            walkable2.Walk();

            ICryable cryable1 = new Dog();

            ICryable cryable2 = new Cat();

            cryable1.Cry();

            cryable2.Cry();
        }

        #endregion
    }
}