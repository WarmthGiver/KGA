/*
이름: 이시온
날짜: 2024.11.26

## 과제 0. 전쟁 게임의 일부를 구현합니다

-ReadLine을 통해 유저로부터 정수를 입력받아서..(숫자만 받는다고 가정)
    
    1을 입력받을 경우, "Cocked Pistol 발령"
    
    2일 경우, "Fast Pace 발령"
    
    3일 경우, "Round House 발령" 
    
    이외에 대한 입력값은 "비상 태세" 
    

출력하는 기능을 if문으로 제작하고,
이와 똑같은 내용으로 switch 문으로 제작하시오.
 */

using System;

namespace Homework0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.Clear();

            if (a == 1)
            {
                Console.WriteLine("Cocked Pistol 발령");
            }

            else if (a == 2)
            {
                Console.WriteLine("Fast Pace 발령");
            }

            else if (a == 3)
            {
                Console.WriteLine("Round House 발령");
            }

            else
            {
                Console.WriteLine("비상 태세");
            }

            switch (a)
            {
                case 1:

                    Console.WriteLine("Cocked Pistol 발령");

                    break;

                case 2:

                    Console.WriteLine("Fast Pace 발령");

                    break;

                case 3:
                    
                    Console.WriteLine("Round House 발령");

                    break;

                default:

                    Console.WriteLine("비상 태세");

                    break;
            }
        }
    }
}