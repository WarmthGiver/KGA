/*
날짜: 24.12.11
이름: 이시온

## 과제 6) static 메서드 내에서 일반 지역변수 활용 체험하기

클래스 내, static메소드에서 static이 아닌 맴버 변수를 활용하는 것은 불가능한것을 확인 하였지만,
이번엔 static 메소드 내에 static을 붙이지 않은 지역변수를 만든 후 문제가 없는지 확인하여보자.
클래스 메소드 속에 static 지역변수는 만들어지는지도 확인하여보자
*/

using System;

namespace Homework6
{
    internal class Program
    {
        private static void Main(string[] args)
        {

        }
    }

    public class MyClass
    {
        private static int staticValue = 0;

        private int value = 0;

        public static void IncreaseStaticValue()
        {
            ++staticValue;

            // 이번엔 static 메소드 내에 static을 붙이지 않은 지역변수를 만든 후 문제가 없는지 확인하여보자.
            //++value;
            
            // 클래스 메소드 속에 static 지역변수는 만들어지는지도 확인하여보자
            //static int value = 0;
        }

        public static void IncreaseValue()
        {
            //++value;
        }

        public void WriteStaticValue()
        {
            Console.WriteLine(staticValue);
        }

        public static void SetStaticValueDouble()
        {
            staticValue *= 2;
            MyClass.IncreaseStaticValue();

            //WriteStaticValue();
        }
    }
}