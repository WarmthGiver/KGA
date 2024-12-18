/*
날짜: 24.12.18
이름: 이시온
*/
using System.Diagnostics;

namespace Day21
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ExampleExtensions.Example1();

            //ExampleExtensions.Example2();

            SortingAlgorithmExample1();

        }

        #region 정렬 알고리즘(Sorting Algorithm) 예제

        private static Random random = new();

        private static Stopwatch stopwatch = new();

        private static void SortingAlgorithmExample1()
        {
            const int range = 10000;

            int[] array;

            double sortingTime;

            array = GetRandomArray(range);

            //WriteLineArray(array);

            sortingTime = SelectionSort(array);

            Console.WriteLine($"Selection Sort Time: {sortingTime} sec");

            //WriteLineArray(array);

            array = GetRandomArray(range);

            //WriteLineArray(array);

            sortingTime = BubbleSort(array);

            Console.WriteLine($"Bubble Sort Time: {sortingTime} sec");

            //WriteLineArray(array);

            array = GetRandomArray(range);

            //WriteLineArray(array);

            sortingTime = ArraySort(array);

            Console.WriteLine($"Array Sort Time: {sortingTime} sec");

            //WriteLineArray(array);
        }

        private static int[] GetRandomArray(int range)
        {
            var array = new int[range];

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(0, range);
            }

            return array;
        }

        private static double SelectionSort(in int[] array)
        {
            stopwatch.Restart();

            for (int i = 0; i < array.Length; ++i)
            {
                int j = i;

                for (int k = j + 1; k < array.Length; ++k)
                {
                    if (array[j] > array[k])
                    {
                        j = k;
                    }
                }

                (array[i], array[j]) = (array[j], array[i]);
            }

            stopwatch.Stop();

            return stopwatch.Elapsed.TotalSeconds;
        }

        private static double BubbleSort(in int[] array)
        {
            stopwatch.Restart();

            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = i; j < array.Length; ++j)
                {
                    if (array[i] > array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }

            stopwatch.Stop();

            return stopwatch.Elapsed.TotalSeconds;
        }

        private static double ArraySort(in int[] array)
        {
            stopwatch.Restart();

            Array.Sort(array);

            stopwatch.Stop();

            return stopwatch.Elapsed.TotalSeconds;
        }

        private static void WriteLineArray(in int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine(array[i]);
            }
        }

        #endregion
    }

    #region 확장 메서드(Extension Method) 예제

    public static class ExampleExtensions
    {
        public static void Example1()
        {
            Random random = new();

            while (true)
            {
                Console.Write($"{random.FixedNext(1, 6)} ");

                Thread.Sleep(10);
            }
        }

        // 확장 메서드(Extension Method)
        //
        public static int FixedNext(this Random random, int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static void Example2()
        {
            int[] array = [1, 2, 3, 4, 5];

            List<int> list = [5, 4, 3, 2, 1];

            array.WriteAll();

            Console.WriteLine();

            list.WriteAll();
        }

        public static void WriteAll<T>(this IEnumerable<T> instance)
        {
            foreach (var element in instance)
            {
                Console.Write($"{element} ");
            }
        }
    }

    #endregion
}