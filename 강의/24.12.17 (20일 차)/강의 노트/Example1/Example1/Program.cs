/*
날짜: 24.12.17
이름: 이시온
*/

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //LinkedListExample1();

            //NullableExample1();

            //TernaryOperatorExample1();

            NullCoalescingOperatorExample1();
        }

        #region 연결 리스트(Linked List) 예제

        private static void LinkedListExample1()
        {
            // 연결 리스트(Linked List)
            // 리스트와 유사하지만 노드(Node)라는 개별 요소로 구성되어 있음.
            // 노드는 앞 노드와 뒤 노드를 참조하고 있음.
            // 메모리가 연속적이지 않기 때문에 데이터의 삽입, 삭제가 효율적임.
            // 특정 데이터를 찾으려면 처음부터 순회해야 하기 때문에 비교적 느림.

            LinkedList<int> linkedList = new();

            // AddFirst()
            // 리스트의 맨 앞에 노드를 추가하고 값을 넣는다.
            linkedList.AddFirst(2);

            // AddLast()
            // 리스트의 맨 뒤에 노드를 추가하고 값을 넣는다.
            linkedList.AddLast(3);

            linkedList.AddFirst(1);

            foreach (int element in linkedList)
            {
                Console.WriteLine(element);
            }
        }

        #endregion

        #region 널러블(Nullable) 타입 예제

        private static void NullableExample1()
        {
            // 널러블(Nullable) 타입
            // 타입 뒤에 ?를 붙이면 널러블 타입으로 사용 가능.
            // 변수에 null을 넣을 수 있음.

            //int value = null;
            int? value = null;

            // HasValue {}
            // 변수에 null이 아닌 값이 들어있는지 확인하는 프로퍼티.
            if (value.HasValue == true)
            {
                Console.WriteLine(value);
            }
        }

        #endregion

        #region 삼항 연산자(Ternary Operator) 예제

        private static void TernaryOperatorExample1()
        {
            // 삼항 연산자(Ternary Operator)
            // 단순한 조건문을 간결하게 표현할 수 있는 문법.

            int? value = null;

            bool isNull;

            if (value == null)
            {
                isNull = true;
            }

            else
            {
                isNull = false;
            }

            // 위 조건문을 삼항 연산자로 표현.
            isNull = value == null ? true : false;
        }

        #endregion

        #region Null 병합 연산자(Null Coalescing Operator) 예제

        private static void NullCoalescingOperatorExample1()
        {
            // Null 병합 연산자
            // 변수에 값을 대입할 때 등호 앞에 물음표 두 개를 붙여서 사용.
            // 변수의 값이 null일 경우에만 값을 대입.

            int? value = 0;

            value ??= 1;

            Console.WriteLine(value);

            value = null;

            value ??= 1;

            Console.WriteLine(value);
        }

        #endregion
    }
}