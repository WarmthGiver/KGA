/*
날짜: 24.12.12
이름: 이시온
*/

using System;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //VirtualMethodExample1();

            //AbstractionExample1();

            //UpCastingExample1();

            //DownCastingExample1();

            //GenerinExample1();

            //GenerinExample2();

            //GenerinExample3();

            BoxingUnboxingExample1();
        }

        #region sealed 한정자

        public sealed class SealedClass
        {

        }

        // sealed 한정자가 적용된 클래스는 상속할 수 없음 
        /*
        public class ExampleClass1 : SealedClass
        {

        }
        */

        #endregion

        #region 가상 메서드(Virtual Method) 예제

        public class VirtualExampleClass1
        {
            // virtual 키워드
            // 
            public virtual void Write()
            {
                Console.WriteLine(0);
            }
        }

        public class OverrideExampleClass1 : VirtualExampleClass1
        {
            // override 키워드
            // 
            public override void Write()
            {
                Console.WriteLine(1);
            }
        }

        private static void VirtualMethodExample1()
        {
            VirtualExampleClass1 virtualExampleClass = new();

            OverrideExampleClass1 overrideExampleClass = new();

            virtualExampleClass.Write();

            overrideExampleClass.Write();
        }

        #endregion

        #region 추상화(Abstraction) 예제

        // abstract
        // 클래스/메서드를 상속만 가능하게 만드는 키워드.

        // 추상 클래스(Abstract Class)
        // 직접 객체를 생성할 수 없고 상속만 가능.
        protected abstract class Animal
        {
            public string name;

            protected Animal(string name)
            {
                this.name = name;
            }

            public int GetLegsCount()
            {
                return 2;
            }

            // 추상 메서드
            // 선언만 가능하고 본문은 선언 불가.
            // 추상 클래스를 상속 받은 클래스는 추상 메서드를 반드시 선언해야 함.
            public abstract void Cry();
        }

        private class Dog : Animal
        {
            public Dog() : base("Dog") { }

            public override void Cry()
            {
                Console.WriteLine($"{name}: Woof!");
            }

            // new 키워드
            // 상속 된 클래스의 필드/메서드를 숨기고 새로 선언하는 키워드.
            // 바람직한 방법은 아님.
            public new int GetLegsCount()
            {
                return 4;
            }
        }

        private class Duck : Animal
        {
            public Duck() : base("Duck") { }

            public override void Cry()
            {
                Console.WriteLine($"{name}: Quack!");
            }

            public void Fly()
            {
                Console.WriteLine($"{name}: Flap!");
            }
        }

        private static void AbstractionExample1()
        {
            Dog dog = new();

            Duck duck = new();

            dog.Cry();

            duck.Cry();
        }

        #endregion

        #region 업 캐스팅(Up Casting) 예제

        private static void UpCastingExample1()
        {
            // 업 캐스팅(Up Casting)
            // 자식 클래스를 부모 클래스에 할당 가능.
            // 
            Animal animal1 = new Dog();
            Animal animal2 = new Duck();

            animal1.Cry();
            animal2.Cry();
        }

        #endregion

        #region 다운 캐스팅(Down Casting) 예제

        // 다운 캐스팅(Up Casting)
        // 부모 클래스를 타입을 자식 클래스 타입으로 캐스팅 가능.

        private static void DownCastingExample1()
        {
            Animal animal = new Duck();

            // Duck 클래스의 Fly 메서드를 호출할 수 없음.
            //animal.Fly();

            // ? 키워드
            // 변수에 null을 넣을 수 있게 해주는 키워드.
            Duck? duck = null;

            // 변수 뒤에 ? 키워드를 붙이고 필드/메서드를 호출하면 변수가 null일 때 null을 반환.
            string? name = duck?.name;

            int? legsCount = duck?.GetLegsCount();

            duck?.Fly();

            if (name == null)
            {
                Console.WriteLine("name: null");
            }

            if (name != null)
            {
                Console.WriteLine($"name: {name}");
            }

            if (legsCount == null)
            {
                Console.WriteLine($"legsCount: null");
            }

            else if (legsCount != null)
            {
                Console.WriteLine($"legsCount: {legsCount}");
            }

            // 다운 캐스팅(Up Casting)
            // 부모 클래스를 타입을 자식 클래스 타입으로 캐스팅.
            duck = (Duck)animal;

            // animal을 Duck 타입으로 캐스팅하여 Fly 메서드 호출 가능.
            duck.Fly();

            // is 키워드
            // 캐스팅이 가능한지의 여부를 bool값으로 반환해주는 키워드.

            if (animal is Duck)
            {
                Console.WriteLine($"{animal}은/는 Duck입니다.");
            }

            // not 키워드
            // is의 결과값을 반대로 해주는 키워드.
            if (animal is not Duck)
            {
                Console.WriteLine($"{animal}은/는 Duck이 아닙니다.");
            }

            Animal dog = new Dog();

            if (dog is Duck)
            {
                Console.WriteLine($"{dog}은/는 Duck입니다.");
            }

            if (dog is not Duck)
            {
                Console.WriteLine($"{dog}은/는 Duck이 아닙니다.");
            }

            // as 키워드
            // 캐스팅을 안전하게 할 수 있는 키워드.
            // 캐스팅 할 수 없는 타입이라면 null값을 반환.
            duck = animal as Duck;

            if (duck == null)
            {
                Console.WriteLine($"{animal}은/는 Duck이 될 수 없습니다.");
            }

            if (duck != null)
            {
                Console.WriteLine($"{animal}은/는 Duck이 될 수 있습니다.");
            }

            duck = dog as Duck;

            if (duck == null)
            {
                Console.WriteLine($"{dog}은/는 Duck이 될 수 없습니다.");
            }

            if (duck != null)
            {
                Console.WriteLine($"{dog}은/는 Duck이 될 수 있습니다.");
            }
        }

        #endregion

        #region 제네릭(Generic) 예제 1

        // 제네릭(Generic)
        // 다양한 형태의 자료형을 일반화하여 
        public class GenericClass1<T>
        {
            public T Value { get; set; }

            public GenericClass1(T value)
            {
                Value = value;
            }
        }

        private static void GenerinExample1()
        {
            GenericClass1<int> intClass = new(1);

            GenericClass1<float> floatClass = new(2.0f);

            GenericClass1<char> charClass = new('3');

            GenericClass1<string> stringClass = new("4");

            Console.WriteLine(intClass.Value);

            Console.WriteLine(floatClass.Value);

            Console.WriteLine(charClass.Value);

            Console.WriteLine(stringClass.Value);
        }

        #endregion

        #region 제네릭(Generic) 예제 2

        public class GenericClass2<T>

            // where 키워드
            // 
            where T : class, new()
        {
            public T Value { get; private set; } = new();
        }

        public class MyClass1
        {
            public int Value { get; set; } = 0;
        }

        private static void GenerinExample2()
        {
            GenericClass2<MyClass1> myClassClass = new();

            Console.WriteLine(myClassClass.Value.Value);
        }

        #endregion

        #region 제네릭(Generic) 예제 3

        public class KeyAndValue<T1, T2>
        {
            public T1? Key { get; set; }

            public T2? Value { get; set; }
        }

        private static void GenerinExample3()
        {
            KeyAndValue<string, int> keyAndValue = new();

            keyAndValue.Key = "Key";

            keyAndValue.Value = 1;

            Console.WriteLine($"Key: {keyAndValue.Key}");

            Console.WriteLine($"Value: {keyAndValue.Value}");
        }

        #endregion

        #region 박싱(Boxing)/언박싱(Unboxing) 예제

        private static void BoxingUnboxingExample1()
        {
            // object 타입
            // 모든 타입을 담을 수 있는 타입.
            // 참조 타입이기 때문에 힙 공간에 할당됨.
            // 타입이 불확실하기 때문에 안정성이 보장되지 않음.

            // 박싱(Boxing)
            // 값 타입을 object 타입에 담는 행위.

            // 언박싱(Unboxing)
            // 값 타입을 담은 object 타입을 다시 값 타입으로 캐스팅 하는 행위.

            // 잦은 박싱/언박싱은 성능 저하를 일으킴.
            // 필요한 경우가 아니면 사용을 지양.

            // 박싱
            object intObj = 1;

            // 언박싱
            int intValue = (int)intObj;

            Console.WriteLine(intValue);
        }

        #endregion
    }
}