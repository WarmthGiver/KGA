namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //IndexerExample1();

            //ListExample1();

            //ListExample2();

            //DictionaryExample1();

            //DictionaryExample2();

            //StackExample1();

            QueueExample1();
        }

        #region 인덱서(Indexer) 예제

        public sealed class Inventory
        {
            private readonly int[] items;

            public int[] Items => items;

            // 인덱서(Indexer)
            // 
            public int this[int index]
            {
                get => items[index];

                set => items[index] = value;
            }

            public Inventory(int size)
            {
                items = new int[size];
            }

            public int GetItem(int index)
            {
                return items[index];
            }
        }

        private static void IndexerExample1()
        {
            Inventory inventory = new(3);

            inventory.Items[0] = 0;

            inventory.Items[1] = 1;

            inventory.Items[2] = 2;

            Console.WriteLine(inventory.Items[0]);

            Console.WriteLine(inventory.GetItem(1));

            Console.WriteLine(inventory[2]);
        }

        #endregion

        #region 리스트(List) 예제 1

        private static void ListExample1()
        {
            // 리스트(List)
            // 
            List<int> list = new() { 1 };

            // Add()
            // 
            list.Add(2);

            // 
            //list[2] = 3;
            list.Add(3);

            for (int i = 0; i < list.Count; ++i)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
        }

        #endregion

        #region 리스트(List) 예제 2

        private static void ListExample2()
        {
            List<List<int>> list = [[1, 2, 3], [4, 5]];

            list[1].Add(6);

            list.Add([7, 8]);

            list[2].Add(9);

            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = 0; j < list[i].Count; ++j)
                {
                    Console.Write(list[i][j]);
                }

                Console.WriteLine();
            }
        }

        #endregion

        #region 딕셔너리(Dictionary) 예제 1

        private static void DictionaryExample1()
        {
            // 딕셔너리(Dictionary)
            // 
            Dictionary<int, string> dictionary = new() { { 0, "A" } };

            // Add()
            // 
            dictionary.Add(1, "B");

            // 
            dictionary[2] = "C";

            for (int i = 0; i < dictionary.Count; ++i)
            {
                Console.WriteLine(dictionary[i]);
            }
        }

        #endregion

        #region 딕셔너리(Dictionary) 예제 2

        private static void DictionaryExample2()
        {
            Dictionary<string, int> dictionary = new(3);

            dictionary["A"] = 1;

            dictionary["B"] = 2;

            dictionary["C"] = 3;

            Console.WriteLine(dictionary["A"]);

            Console.WriteLine(dictionary["B"]);

            Console.WriteLine(dictionary["C"]);

            // ContainsKey()
            // 
            if (dictionary.ContainsKey("D") == true)
            {
                Console.WriteLine(dictionary["D"]);
            }
        }

        #endregion

        #region 스택(Stack) 예제

        private static void StackExample1()
        {
            // 스택(Stack)
            // 선입후출(FILO) & 후입선출(LIFO) 구조.
            // 데이터를 꺼낼 때 가장 마지막에 들어온 데이터가 꺼내짐.
            Stack<int> stack = new();

            // Push()
            // 
            stack.Push(1);

            stack.Push(2);

            stack.Push(3);

            // Any()
            // 
            while (stack.Any())
            {
                // Peek()
                //
                Console.WriteLine(stack.Peek());

                // Pop()
                //
                stack.Pop();
            }
        }

        #endregion

        #region Queue(Stack) 예제

        private static void QueueExample1()
        {
            // 큐(Queue)
            // 선입선출(FIFO) & 후입후출(LILO) 구조.
            // 데이터를 꺼낼 때 가장 먼저 들어온 데이터가 꺼내짐.
            Queue<int> queue = new();

            // Enqueue()
            // 
            queue.Enqueue(1);

            queue.Enqueue(2);

            queue.Enqueue(3);

            // Any()
            // 
            while (queue.Any())
            {
                // Peek()
                //
                Console.WriteLine(queue.Peek());

                // Dequeue()
                //
                queue.Dequeue();
            }
        }

        #endregion
    }
}