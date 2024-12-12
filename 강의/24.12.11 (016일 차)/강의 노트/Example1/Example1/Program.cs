/*
날짜: 24.12.11
이름: 이시온
*/

using System;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //StaticExample1();

            //SingletonExample1();

            InheritanceExample1();
        }

        #region 정적 필드/메서드 예제

        public class StaticExampleClass
        {
            // 정적 필드(Static Field)
            // 
            public static int staticValue = 0;

            // 동적 필드(Dynamic Field)
            // 
            public int value = 0;

            // 정적 메서드(Static Method)
            // 
            public static int GetStaticValue()
            {
                // 정적 메서드에서는 정적 필드/메소드만 접근 가능.
                //return value;

                return staticValue;
            }

            public int GetValue()
            {
                return value;
            }
        }

        private static void StaticExample1()
        {
            Console.WriteLine($"staticValue: {StaticExampleClass.staticValue}");

            StaticExampleClass.staticValue = 1;

            Console.WriteLine($"staticValue = {StaticExampleClass.staticValue}");

            Console.WriteLine($"staticValue: {StaticExampleClass.staticValue}");

            // 동적 필드 접근 불가능.
            //StaticExampleClass.value = 1;

            // 동적 메서드 접근 불가능.
            //StaticExampleClass.GetValue();
        }

        #endregion

        #region 정적 클래스 예제

        // 정적 클래스(Static Class)
        // 
        public static class StaticClass
        {
            public static int staticValue = 0;

            // 동적 필드 선언 불가능.
            //public int value = 0;

            public static int GetStaticValue()
            {
                return staticValue;
            }

            // 동적 메서드 선언 불가능.
            /*
            public int GetValue()
            {
                return value;
            }
            */
        }

        #endregion

        #region 싱글톤(Singleton) 예제

        public sealed class SingletonExampleClass
        {
            // Singleton
            // 
            private static SingletonExampleClass? instance = null;

            public static SingletonExampleClass Instance
            {
                get
                {
                    // 게으른 초기화(Lazy Instantiation)
                    // 
                    if (instance == null)
                    {
                        instance = new SingletonExampleClass();
                    }

                    return instance;
                }
            }

            public int value = 0;
        }

        private static void SingletonExample1()
        {
            // 인스턴스를 통해 동적 변수에 접근 가능.
            Console.WriteLine($"value: {SingletonExampleClass.Instance.value}");
        }

        #endregion

        #region 상속(Inheritance) 예제

        public class Dog
        {
            private string name;

            protected int age;

            public Dog(string name, int age)
            {
                this.name = name;

                this.age = age;
            }

            public void SetName(string name)
            {
                this.name = name;
            }

            public void Cry()
            {
                Console.WriteLine($"{name}: Woof!");
            }
        }

        // 상속(Inheritance)
        // 
        private class Greyhound : Dog
        {
            // base
            // 클래스 내에서 상속 받은 클래스의 필드/메서드에 접근 가능.
            public Greyhound(string name, int age) : base(name, age) { }

            public void SetInfo(string name, int age)
            {
                // private 필드는 접근 불가능.
                //base.name = name;
                SetName(name);

                // protected 필드는 접근 가능.
                this.age = age;
            }
        }

        private static void InheritanceExample1()
        {
            Dog dog = new("Doge", 1);

            Greyhound greyhound = new("Maru", 2);

            dog.Cry();

            // 상속 받은 클래스의 메서드를 호출 가능.
            greyhound.Cry();
        }

        #endregion
    }
}