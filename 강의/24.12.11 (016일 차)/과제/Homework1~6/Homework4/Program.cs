/*
날짜: 24.12.11
이름: 이시온

## 과제 4) static 메서드 체험하기

새로운 일반 클래스를 하나 만들고,
맴버 변수로 private static 정수형 하나,
일반 private 정수형 하나를 가지고 있게 하자.
맴버 함수(메소드) public void 형태의 메서드를 만들되, 맴버 변수로 보유중인 스태틱 변수를 +1이 되는 기능을 작성하자.
방금 만든 함수의 void 앞에 static을 붙인 후,
메인에서 [클래스명.함수이름] 이 작동하는지 확인하여보자.
두번째로, 똑같이 public static void 로 일반 맴버변수를 증가시키는 기능을 하나 만든 후, 문제가 생기는지 확인하여보자.
*/

namespace Homework4
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            // 메인에서 [클래스명.함수이름] 이 작동하는지 확인하여보자.
            MyClass.IncreaseStaticValue();
        }
    }

    // 새로운 일반 클래스를 하나 만들고,
    public class MyClass
    {
        // 맴버 변수로 private static 정수형 하나,
        private static int staticValue = 0;

        // 일반 private 정수형 하나를 가지고 있게 하자.
        private int value = 0;

        // 맴버 함수(메소드) public void 형태의 메서드를 만들되, 맴버 변수로 보유중인 스태틱 변수를 +1이 되는 기능을 작성하자.
        // 방금 만든 함수의 void 앞에 static을 붙인 후,
        public static void IncreaseStaticValue()
        {
            ++staticValue;
        }

        // 두번째로, 똑같이 public static void 로 일반 맴버변수를 증가시키는 기능을 하나 만든 후, 문제가 생기는지 확인하여보자.
        public static void IncreaseValue()
        {
            //++value;
        }
    }
}