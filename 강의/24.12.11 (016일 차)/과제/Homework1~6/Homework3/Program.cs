/*
날짜: 24.12.11
이름: 이시온

## 과제 3) static 프로퍼티 체험하기

위 클래스에서 static 변수를 다시 private으로 바꾸고,
프로퍼티를 활용하여, 접근이 가능한지 알아보자.
방금 만든 public 프로퍼티에도 static을 붙여서 위 변수 접근처럼 [클래스명.프로퍼티] 접근이 가능한지 알아보고,
static이 아닌 일반 정수형을 하나 만든 후,
public static 프로터피로 일반 정수형을 다룰 수 있는지 알아보자.
*/

using System;

namespace Homework3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 방금 만든 public 프로퍼티에도 static을 붙여서 위 변수 접근처럼 [클래스명.프로퍼티] 접근이 가능한지 알아보고,
            MyClass.Value = 1;
        }
    }

    public class MyClass
    {
        // 위 클래스에서 static 변수를 다시 private으로 바꾸고,
        private static int value = 0;

        // 프로퍼티를 활용하여, 접근이 가능한지 알아보자.
        public static int Value
        {
            get
            {
                return value;
            }

            set
            {
                MyClass.value = value;
            }
        }

        // static이 아닌 일반 정수형을 하나 만든 후,
        private int value2 = 0;

        // public static 프로터피로 일반 정수형을 다룰 수 있는지 알아보자.
        /*
        public static int Value2
        {
            get
            {
                return value2;
            }

            set
            {
                value2 = value;
            }
        }
        */
    }
}