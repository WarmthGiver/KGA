/*
이름: 이시온
날짜: 24.12.02

**과제 1. 열거형 리팩토링**

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("이동 할 장소를 설정해주세요");
        Console.WriteLine("1. 마을");
        Console.WriteLine("2. 사냥터");
        Console.WriteLine("3. 상점");
        int toDetermine;

        int.TryParse(Console.ReadLine(), out toDetermine);
        Console.Clear(); //화면을 지워줍니다
        switch (toDetermine)
        {
            case 1:
                Console.WriteLine("마을로 이동합니다");
                break;
            case 2:
                Console.WriteLine("사냥터로 이동합니다");
                break;
            case 3:
                Console.WriteLine("상점으로 이동합니다");
                break;
            default:
                Console.WriteLine("1,2,3 어느것도 아니에요");
                break;
        }
    }
}

```

- 위 코드는 과거 스위치문을 배울 때, 적었던 코드입니다. 해당 코드는 스위치 문에서 1,2와 같이 숫자로만 적혀있어 가독성이 떨어지는 문제를 가지고 있습니다. 열거형을 활용하여 해당 코드를 더욱 알아보기 쉽게 수정하여주세요.
*/
using System;

namespace Homework1
{
    internal class Program
    {
        private enum MapType
        {
             마을 = 1,
             사냥터 = 2,
             상점 = 3,
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("이동 할 장소를 설정해주세요");
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 사냥터");
            Console.WriteLine("3. 상점");

            MapType toDetermine;
            Enum.TryParse(Console.ReadLine(), out toDetermine);
            Console.Clear(); //화면을 지워줍니다
            switch (toDetermine)
            {
                case MapType.마을:
                    Console.WriteLine("마을로 이동합니다");
                    break;
                case MapType.사냥터:
                    Console.WriteLine("사냥터로 이동합니다");
                    break;
                case MapType.상점:
                    Console.WriteLine("상점으로 이동합니다");
                    break;
                default:
                    Console.WriteLine("1,2,3 어느것도 아니에요");
                    break;
            }
        }
    }
}