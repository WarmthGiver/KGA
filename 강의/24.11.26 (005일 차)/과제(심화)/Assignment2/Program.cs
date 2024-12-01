/*
이름: 이시온
날짜: 2024.11.26

### 심화 과제 2. 입력을 통한 다이아몬드 출력 기능 구현

- 출력할 다이아몬드 형태를 사용자로부터 입력 받은 후, 만약 짝수일경우 홀수를 다시 입력하라고 유저에게 무한 반복으로 요구한다.
- 홀수가 입력되었을 경우, 다이아몬드 중간 부분이 유저의 입력과 같은 다이아몬드를 출력하는 프로그램 제작.
- https://img.notionusercontent.com/s3/prod-files-secure%2Fecbfc15b-d9e9-421e-911d-a5bceae47cb4%2F9bf7f0e1-ab5c-42b5-9b00-7ed7c700d3bd%2Fimage.png/size/w=1300?exp=1733149928&sig=b1GZnk_u1KDfDDLvb3vzavkt4YJn8E-NoanZNoeUS7w
 */
using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 다이아몬드 크기를 저장하는 변수.
            int size;

            // 입력 받은 값이 홀수일 때 까지 반복.
            while (true)
            {
                Console.Write("다이아몬드 크기 입력(홀수): ");

                // 다이아몬드 크기 입력
                int.TryParse(Console.ReadLine(), out size);

                Console.Clear();
                
                //* != *
                //좌변과 우변이 다른지 비교하는 비교 연산자.
                //좌변과 우변이 다르면 true, 같다면 false.

                // 만약 다이아몬드의 크기가 홀수라면,
                if (size % 2 != 0)
                {
                    // 반복문 종료.
                    break;
                }
                // 아래와 같은 방식으로 해도 무방.
                /*
                // 만약 다이아몬드의 크기가 짝수라면,
                if (size % 2 == 0)
                {
                    // 다시 반복.
                    continue;
                }

                // 아니라면 반복문 종료.
                break;
                */
            }

            Console.Clear();

            // 다이아몬드 크기의 절반 값 저장.
            // 다이아몬드 크기의 절반 값은 계속 
            int halfSize = size / 2;

            // 다이아몬드의 윗 부분과 중간 부분을 출력해야 하기 때문에 (halfSize + 1)만큼 반복.
            //for (int i = 0; i < halfSize + 1; ++i)
            // 위 방식은 매번 조건식을 비교할 때마다 (halfSize + 1)을 연산하기 때문에 아래와 같이 최적화 해준 것.
            for (int i = 0; i <= halfSize; ++i)
            {
                // ' '의 개수는 halfSize부터 시작해 1씩 감소하기 때문에 (halfSize - i)만큼 출력.
                //for (int j = 0; j < halfSize - i; ++j)
                // 위 방식은 매번 조건식을 비교할 때마다 (halfSize - 1)을 연산하기 때문에 아래와 같이 최적화 해준 것.
                for (int j = i; j < halfSize; ++j)
                {
                    Console.Write(' ');
                }
                // 아래와 같이 최적화 해도 무방.
                /*
                int blankCount = halfSize - i;

                for (int j = 0; j < blankCount; ++j)
                {
                    Console.Write('*');
                }
                */
                // '*'의 개수는 1부터 시작해 (i * 2)만큼 점점 증가하기 때문에 (1 + i * 2)만큼 출력.
                //for (int j = 0; j < 1 + i * 2; ++j)
                // 위 방식은 매번 조건식을 비교할 때마다 (1 + i * 2)를 연산하기 때문에 아래와 같이 최적화.
                for (int j = 1 + i * 2; j > 0; --j)
                {
                    Console.Write('*');
                }
                // 아래와 같이 최적화 해도 무방.
                /*
                int starCount = 1 + i * 2;

                for (int j = 0; j < starCount; ++j)
                {
                    Console.Write('*');
                }
                */
                Console.WriteLine();
            }

            // 다이아몬드의 아랫 부분을 출력해야 하기 때문에 halfSize만큼 반복.
            // i를 (halfSize - 1)로 초기화 하는 이유는 중간 부분을 위에서 이미 출력했기 때문.
            // halfSize를 그대로 넣으면 중간 부분까지 출력됨.
            //for (int i = halfSize; i >= 0; --i)
            for (int i = halfSize - 1; i >= 0; --i)
            {
                // 안쪽은 위 방식과 동일.

                for (int j = i; j < halfSize; ++j)
                {
                    Console.Write(' ');
                }

                for (int j = 1 + i * 2; j > 0; --j)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}