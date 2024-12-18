/*
날짜: 24.12.16
이름: 이시온
*/
/*
### **심화 과제 ) 큐 사용**

Milk라는 클래스와 VendingMachine 이라는 클래스를 하나 만들겠습니다. Milk의 맴버변수로, 유통기한을 나타내는 int를 작성해주시기 바랍니다.

VendingMachine 클래스에는 Queue를 활용하여 Milk를 담을 수 있는 컨테이너를 필드로 작성하여 주시기 바랍니다. 

벤딩머신의 메소드로, 우유를 집어넣는 코드와 우유를 꺼내는 기능을 작성하되,
꺼낼때는 콘솔에 유통기한 및 큐에 남아있는 갯수를 출력하는 기능을 작성해주시기 바랍니다.
갯수가 0일때 우유를 꺼내는 기능을 호출하게 되면 꺼내는 대신 다른 멘트가 나오게끔 작성해주시길 바랍니다.
*/

namespace Assignment3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            VendingMachine vendingMachine = new();

            vendingMachine.EnqueueMilk(new(1));

            vendingMachine.EnqueueMilk(new(2));

            vendingMachine.EnqueueMilk(new(3));

            vendingMachine.DequeueMilk();

            vendingMachine.DequeueMilk();

            vendingMachine.DequeueMilk();

            vendingMachine.DequeueMilk();
        }

        // Milk라는 클래스와
        public sealed class Milk
        {
            // Milk의 맴버변수로, 유통기한을 나타내는 int를 작성해주시기 바랍니다.
            public readonly int exp;

            public Milk(int exp)
            {
                this.exp = exp;
            }
        }

        // VendingMachine 이라는 클래스를 하나 만들겠습니다.
        public sealed class VendingMachine
        {
            // VendingMachine 클래스에는 Queue를 활용하여 Milk를 담을 수 있는 컨테이너를 필드로 작성하여 주시기 바랍니다. 

            private readonly Queue<Milk> milks = new();

            // 벤딩머신의 메소드로, 우유를 집어넣는 코드와,
            public void EnqueueMilk(Milk milk)
            {
                milks.Enqueue(milk);
            }

            // 우유를 꺼내는 기능을 작성하되,
            public Milk? DequeueMilk()
            {
                Console.WriteLine();

                // 꺼낼때는 콘솔에 유통기한 및 큐에 남아있는 갯수를 출력하는 기능을 작성해주시기 바랍니다.
                if (milks.Any() == true)
                {
                    var milk = milks.Dequeue();

                    Console.WriteLine($"유통기한: {milk.exp}");

                    Console.WriteLine();

                    Console.WriteLine($"남은 우유: {milks.Count}");

                    return milk;
                }

                // 갯수가 0일때 우유를 꺼내는 기능을 호출하게 되면 꺼내는 대신 다른 멘트가 나오게끔 작성해주시길 바랍니다.
                Console.WriteLine("우유가 없습니다.");

                return null;
            }
        }
    }
}