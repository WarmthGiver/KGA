/*
날짜: 24.12.11
이름: 이시온

## 과제 2) static 접근법 체험하기

아까 만든 클래스에서 static 변수를 public 으로 바꾸어 보자.
그 후, 메인에서 [클래스명.스태틱변수] int형에 담거나 출력해보는 코드를 작성하여 에러가 나는지 안나는지 확인하여보자.
*/

using System;

namespace Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 그 후, 메인에서 [클래스명.스태틱변수] int형에 담거나 출력해보는 코드를 작성하여 에러가 나는지 안나는지 확인하여보자.
            MyClass.value = 1;

            Console.WriteLine(MyClass.value);

            ++MyClass.value;

            Console.WriteLine(MyClass.value);
        }
    }

    public class MyClass
    {
        // 아까 만든 클래스에서 static 변수를 public 으로 바꾸어 보자.
        public static int value = 0;
    }
}