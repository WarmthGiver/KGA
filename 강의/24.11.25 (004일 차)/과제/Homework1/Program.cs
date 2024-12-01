/*
이름: 이시온
날짜: 2024.11.25

과제 1. 이름 입력받아 출력

- 이름을 입력받아, 반갑다고 출력하는 프로그램을 작성해주세요
  - "당신의 이름을 입력해주세요" 출력
  - 다음줄에서 이름을 입력 받기
  - "(방금입력받은이름)님, 반갑습니다" 출력하는 프로그램
*/

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