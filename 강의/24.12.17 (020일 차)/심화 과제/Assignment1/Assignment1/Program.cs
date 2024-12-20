/*
날짜: 24.12.17
이름: 이시온
*/
/*
### 심화 과제 ) LinkedList 확장

오늘의 LinkedList 수동 구현 과제를 리팩토링 혹은 기능을 추가하여 양방향 연결 리스트 기능을 수행 가능하게끔 만들어 주세요
*/

using System.Collections;

namespace Assignment1
{
    internal class Program
    {
        private static void Main(string[] args)
       {
            DoubleLinkedList<int> doubleLinkedList = new();

            doubleLinkedList.AddLast(3);

            foreach (int value in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.AddFirst(1);

            foreach (int value in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.AddLast(5);

            foreach (int value  in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.TryAddBefore(1, 2);

            foreach (int value in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.TryAddAfter(2, 4);

            foreach(int value  in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.TryRemove(3);

            foreach (int value in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.TryRemove(1);

            foreach (int value in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.TryRemoveLast();

            foreach (int value in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.TryRemoveFirst();

            foreach (int value in doubleLinkedList)
            {
                Console.Write(value);
            }

            Console.WriteLine();

            doubleLinkedList.Clear();

            foreach (int value in doubleLinkedList)
            {
                Console.Write(value);
            }
        }

        public sealed class DoubleLinkedList<T> : IEnumerable<T>

            where T : struct
        {
            private readonly Node head;

            private readonly Node tail;

            private int count = 0;

            public int Count => count;

            public T? this[int index]
            {
                get
                {
                    if (TryFind(index, out T value) == true)
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

            public IEnumerator<T> GetEnumerator()
            {
                for (Node node = head.back; node != tail; ++node)
                {
                    yield return node.value;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public void AddFirst(T value)
            {
                AddAfter(head, value);

                ++count;
            }

            public bool TryAddAfter(int index, T value)
            {
                if (TryFind(index, out Node? node) == false)
                {
                    return false;
                }

                AddAfter(node, value);

                return true;
            }

            public void AddAfter(Node node, T value)
            {
                Node newNode = new()
                {
                    value = value,

                    front = node,

                    back = node.back
                };

                node.back.front = newNode;

                node.back = newNode;

                ++count;
            }

            public void AddLast(T value)
            {
                AddBefore(tail, value);

                ++count;
            }

            public bool TryAddBefore(int index, T value)
            {
                if (TryFind(index, out Node? node) == false)
                {
                    return false;
                }

                AddBefore(node, value);

                return true;
            }

            public void AddBefore(Node node, T value)
            {
                Node newNode = new()
                {
                    value = value,

                    front = node.front,

                    back = node
                };

                node.front.back = newNode;

                node.front = newNode;

                ++count;
            }

            public bool TryRemoveFirst()
            {
                if (count > 0)
                {
                    head.back.Unlink();

                    --count;

                    return true;
                }

                return false;
            }

            public bool TryRemoveLast()
            {
                if (count > 0)
                {
                    tail.front.Unlink();

                    --count;

                    return true;
                }

                return false;
            }

            public bool TryRemove(Node target)
            {
                if (count > 0)
                {
                    target.Unlink();

                    --count;

                    return true;
                }

                return false;
            }

            public bool TryRemove(int index)
            {
                if (TryFind(index, out Node? target) == true)
                {
                    target.Unlink();

                    --count;

                    return true;
                }

                return false;
            }

            public bool TryFind(int index, out T result)
            {
                if (TryFind(index, out Node? node) == true)
                {
                    result = node.value;

                    return true;
                }

                result = default;

                return false;
            }

            public bool TryFind(int index, out Node? result)
            {
                result = head;

                while (++result != tail)
                {
                    if (index-- == 0)
                    {
                        return true;
                    }
                }

                result = null;

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
                public T value;

                internal Node? front = null;

                public Node? Front => front;

                internal Node? back = null;

                public Node? Back => back;

                public static Node? operator ++(Node node)
                {
                    return node.back;
                }

                public static Node? operator --(Node node)
                {
                    return node.front;
                }

                internal void Unlink()
                {
                    if (front != null && back != null)
                    {
                        front.back = back;

                        back.front = front;
                    }
                }
            }
        }
    }
}