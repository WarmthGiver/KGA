/*
날짜: 25.01.02
이름: 이시온
*/

using System;

using System.Diagnostics;

namespace Example1
{
    internal class Program
    {
        private static int x;

        private static void Main(string[] args)
        {
            Stopwatch time = new();

            time.Start();

            Start();

            while (true)
            {
                if (time.ElapsedMilliseconds >= 16)
                {
                    time.Restart();

                    Update();
                }
            }
        }

        private static void Start()
        {
            x = 0;
        }

        private static void Update()
        {
            x += 1;

            Console.WriteLine(x);
        }
    }
}