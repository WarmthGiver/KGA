/*
이름: 이시온
날짜: 2024.11.26

## 과제 4. 별찍기 기능 구현

- 중첩반복문을 활용하여 아래 그림처럼 출력을 시켜 보겠습니다.
    
    하나 하나 만들어보시기 바랍니다
    
- `Tip` : `Console.Write(" ");`를 쓰면 빈 공백 하나를, `Console.Write("*");`을 쓰면 별 하나를 출력할 수 있다
- https://img.notionusercontent.com/s3/prod-files-secure%2Fecbfc15b-d9e9-421e-911d-a5bceae47cb4%2Fbb5a9f19-88a7-43ad-965d-ac81db7c0873%2Fimage.png/size/w=790?exp=1733150001&sig=W8LOvVr_D5oYJf0jhdK6TvIjoEKZapcp71vfxgGoCwM
 */
using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;

            for (int i = 1; i <= count; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= count; ++i)
            {
                for (int j = i; j < count; ++j)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < i; ++j)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = count; i >= 1; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = count; i >= 1; --i)
            {
                for (int j = i; j < count; ++j)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < i; ++j)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}