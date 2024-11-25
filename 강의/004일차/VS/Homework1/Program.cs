using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("당신의 이름을 입력해주세요");

            string name = Console.ReadLine();

            Console.WriteLine($"{name}님, 반갑습니다.");
        }
    }
}
