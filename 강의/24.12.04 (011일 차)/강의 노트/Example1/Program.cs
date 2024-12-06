using System;
using System.Diagnostics;
using System.Threading;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //StopwatchExample1();
            KeyAvailableExample1();
        }

        private static void StopwatchExample1()
        {
            // Stopwatch
            // 

            Stopwatch stopwatch = new();

            stopwatch.Start();

            while (true)
            {
                Console.WriteLine(stopwatch.ElapsedMilliseconds);
            }
        }

        private static void KeyAvailableExample1()
        {
            // Console.KeyAvailable
            // 

            while (true)
            {
                Console.Write('.');

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;

                    Console.Write(key);
                }

                Thread.Sleep(100);
            }
        }
    }
}