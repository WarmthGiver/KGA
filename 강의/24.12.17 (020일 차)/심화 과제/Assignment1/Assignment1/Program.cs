/*
날짜: 24.12.17
이름: 이시온
*/
/*
### 심화 과제 ) LinkedList 확장

오늘의 LinkedList 수동 구현 과제를 리팩토링 혹은 기능을 추가하여 양방향 연결 리스트 기능을 수행 가능하게끔 만들어 주세요
*/

namespace Assignment1
{
    internal class Program
    {
        private static void Main(string[] args)
       {
            DoubleLinkedList<int> doubleLinkedList = new();

            doubleLinkedList.AddLast(4);

            doubleLinkedList.AddFirst(1);

            for (int i = 0; i < doubleLinkedList.Count; ++i)
            {
                Console.Write(doubleLinkedList[i]);
            }

            Console.WriteLine();

            doubleLinkedList.TryAddBefore(1, 2);

            for (int i = 0; i < doubleLinkedList.Count; ++i)
            {
                Console.Write(doubleLinkedList[i]);
            }

            Console.WriteLine();

            doubleLinkedList.TryAddAfter(1, 3);

            for (int i = 0; i < doubleLinkedList.Count; ++i)
            {
                Console.Write(doubleLinkedList[i]);
            }

            Console.WriteLine();

            doubleLinkedList.TryRemoveFirst();

            for (int i = 0; i < doubleLinkedList.Count; ++i)
            {
                Console.Write(doubleLinkedList[i]);
            }

            Console.WriteLine();

            doubleLinkedList.TryRemoveLast();

            for (int i = 0; i < doubleLinkedList.Count; ++i)
            {
                Console.Write(doubleLinkedList[i]);
            }

            Console.WriteLine();

            doubleLinkedList.TryRemoveLast();

            for (int i = 0; i < doubleLinkedList.Count; ++i)
            {
                Console.Write(doubleLinkedList[i]);
            }

            Console.WriteLine();

            doubleLinkedList.Clear();

            for (int i = 0; i < doubleLinkedList.Count; ++i)
            {
                Console.Write(doubleLinkedList[i]);
            }
        }

        public sealed class DoubleLinkedList<T>

            where T : struct
        {
            private Node head;

            private Node tail;

            private int count = 0;

            public int Count => count;

            public T? this[int index]
            {
                get
                {
                    if (TryFind(index, out var value) == true)
                    {
                        return value;
                    }

                    return null;
                }
            }

            public DoubleLinkedList()
            {
                head = new();

                tail = new();

                head.back = tail;

                tail.front = head;
            }

            public void AddFirst(T value)
            {
                Node node = new()
                {
                    value = value,

                    front = head,

                    back = head.back
                };

                head.back.front = node;

                head.back = node;

                ++count;
            }

            public void AddLast(T? value)
            {
                Node node = new()
                {
                    value = value,

                    front = tail.front,

                    back = tail
                };

                tail.front.back = node;

                tail.front = node;

                ++count;
            }

            public bool TryAddBefore(int index, T value)
            {
                if (TryFindNode(index, out var oldNode) == false)
                {
                    return false;
                }

                Node? newNode = new()
                {
                    value = value,

                    front = oldNode.front,

                    back = oldNode
                };

                oldNode.front.back = newNode;

                oldNode.front = newNode;

                ++count;

                return true;
            }

            public bool TryAddAfter(int index, T value)
            {
                if (TryFindNode(index, out var oldNode) == false)
                {
                    return false;
                }

                Node? newNode = new()
                {
                    value = value,

                    front = oldNode,

                    back = oldNode.back
                };

                oldNode.back.front = newNode;

                oldNode.back = newNode;

                ++count;

                return true;
            }

            public bool TryFind(int index, out T? result)
            {
                if (TryFindNode(index, out var node) == true)
                {
                    result = node.value;

                    return true;
                }

                result = null;

                return false;
            }

            private bool TryFindNode(int index, out Node? result)
            {
                result = head.back;

                for (int i = 0; result != tail; ++i)
                {
                    if (i == index)
                    {
                        return true;
                    }

                    result = result.back;
                }

                result = null;

                return false;
            }

            public bool TryRemove()
            {
                if (count > 0)
                {
                    // 

                    --count;

                    return true;
                }

                return false;
            }

            public bool TryRemoveFirst()
            {
                if (count > 0)
                {
                    head.back.back.front = head;

                    head.back = head.back.back;

                    --count;

                    return true;
                }

                return false;
            }

            public bool TryRemoveLast()
            {
                if (count > 0)
                {
                    tail.front.front.back = head;

                    tail.front = tail.front.front;

                    --count;

                    return true;
                }

                return false;
            }

            public void Clear()
            {
                head.back = tail;

                tail.front = head;

                count = 0;
            }

            public sealed class Node
            {
                public T? value;

                public Node? front = null;

                public Node? back = null;
            }
        }
    }
}