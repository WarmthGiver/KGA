/*
날짜: 24.12.11
이름: 이시온

## 과제 1) static 직접 만들어 보기

일반 클래스를 하나 만든 후,
맴버 변수로 private static 정수를 하나 가지게 하자.
일반 클래스 public 메서드로 해당 static 정수를 하나 1 올리는 메서드와,
해당 static변수를 출력시키는 메서드를 하나 만들어보자.
전부 제작 후, 메인에서 방금 만들어진 클래스로 객체를 3개 만든 후,
방금 만들어진 두 함수를 다양하게 실행해보자

※ 클래스명, 필드, 메서드명 본인이 자유롭게
*/

using System;

namespace Homework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 메인에서 방금 만들어진 클래스로 객체를 3개 만든 후,

            MyClass myClass1 = new();

            MyClass myClass2 = new();

            MyClass myClass3 = new();

            // 방금 만들어진 두 함수를 다양하게 실행해보자

            myClass1.WriteValue();

            myClass2.WriteValue();

            myClass3.WriteValue();

            myClass1.IncreaseValue();

            myClass1.WriteValue();

            myClass2.WriteValue();

            myClass3.WriteValue();

            myClass2.IncreaseValue();

            myClass1.WriteValue();

            myClass2.WriteValue();

            myClass3.WriteValue();

            myClass3.IncreaseValue();

            myClass1.WriteValue();

            myClass2.WriteValue();

            myClass3.WriteValue();
        }
    }

    // 일반 클래스를 하나 만든 후,
    // 전부 제작 후, 메인에서 방금 만들어진 클래스로 객체를 3개 만든 후, 방금 만들어진 두 함수를 다양하게 실행해보자
    public class MyClass
    {
        // 맴버 변수로 private static 정수를 하나 가지게 하자.
        private static int value = 0;

        // 일반 클래스 public 메서드로 해당 static 정수를 하나 1 올리는 메서드와,
        public void IncreaseValue()
        {
            ++value;
        }

        // 해당 static변수를 출력시키는 메서드를 하나 만들어보자.
        public void WriteValue()
        {
            Console.WriteLine(value);
        }
    }
}