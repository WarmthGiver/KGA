/*
날짜: 24.12.11
이름: 이시온

## 과제 5) static 메서드에서 static 호출 체험하기

메인으로 가서 방금 만든 클래스를 활용해 객체를 하나 만들어보자.
객체를 통하여 static함수가 호출되는지 확인하여보자.
에러 메세지를 확인한 후, 주석 처리.
일반 맴버 함수로, 맴버 static변수를 출력하는 기능을 하나 작성하고,
맴버 static변수를 두배시키는 static 메소드도 하나 더 만든 후,
함수 내에서 아까 만들어 둔 static변수+1 하는 메소드와,
일반 맴버함수를 호출하여 보자.
어느 부분서 에러가 뜨는지 확인하여보자
*/

using System;

namespace Homework5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 메인으로 가서 방금 만든 클래스를 활용해 객체를 하나 만들어보자.
            MyClass myClass = new();

            // 객체를 통하여 static함수가 호출되는지 확인하여보자.
            // 에러 메세지를 확인한 후, 주석 처리.
            //myClass.IncreaseStaticValue();
        }
    }

    public class MyClass
    {
        private static int staticValue = 0;

        private int value = 0;

        public static void IncreaseStaticValue()
        {
            ++staticValue;
        }

        public static void IncreaseValue()
        {
            //++value;
        }

        // 일반 맴버 함수로, 맴버 static변수를 출력하는 기능을 하나 작성하고,
        public void WriteStaticValue()
        {
            Console.WriteLine(staticValue);
        }

        // 맴버 static변수를 두배시키는 static 메소드도 하나 더 만든 후,
        public static void SetStaticValueDouble()
        {
            staticValue *= 2;

            // 함수 내에서 아까 만들어 둔 static변수+1 하는 메소드와,
            MyClass.IncreaseStaticValue();

            // 일반 맴버함수를 호출하여 보자.
            //WriteStaticValue();
        }
    }
}