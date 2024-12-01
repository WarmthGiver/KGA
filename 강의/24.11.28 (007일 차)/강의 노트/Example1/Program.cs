/*
이름: 이시온
날짜: 24.11.28
*/
using System;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayExample();

            MultiDimensionalArrayExample();

            StringExample();
        }

        // 배열 예제
        private static void ArrayExample()
        {
            const int skillsCount = 4;

            // 배열(Array)
            // 컬렉션(Collection)
            // [*index*]로 각 공간에 접근 가능.

            #region 배열을 사용하지 않은 방법
            {
                Console.WriteLine("[배열을 사용하지 않은 방법]");

                Console.WriteLine();

                string skill_0 = "결정타";

                string skill_1 = "용기";

                string skill_2 = "심판";

                string skill_3 = "데마시아의 정의";

                Console.WriteLine($"스킬 0: {skill_0}");

                Console.WriteLine($"스킬 1: {skill_1}");

                Console.WriteLine($"스킬 2: {skill_2}");

                Console.WriteLine($"스킬 3: {skill_3}");

                Console.WriteLine();

                Console.Write($"사용할 스킬 번호: ");

                int.TryParse(Console.ReadLine(), out int skillNumber);

                Console.WriteLine();

                string skill = "\0";

                switch (skillNumber)
                {
                    case 0:

                        skill = skill_0;

                        break;

                    case 1:

                        skill = skill_1;

                        break;

                    case 2:

                        skill = skill_2;

                        break;

                    case 3:

                        skill = skill_3;

                        break;
                }

                Console.WriteLine($"\"{skill}!\"");
            }
            #endregion

            Console.WriteLine();

            // new(), new[]
            // 객체(Object)를 초기화 하는 생성자(Constructor)를 호출하는 키워드. 
            // 객체를 생성하여 힙 메모리(Heap Memory)에 저장하고 주소값을 반환,
            // 반환된 주소값을 변수에 대입하면 변수는 객체가 저장된 메모리를 가리키게 됨.
            // 배열의 경우 new[*배열의 길이*]로 초기화.

            // string[] skills = new string[skillsCount]
            // 아래와 같이 단순화 가능
            string[] skills =
            [
                "결정타",

                "용기",

                "심판",

                "데마시아의 정의"
            ];

            #region for를 사용한 방법
            {
                Console.WriteLine("[for를 사용한 방법]");

                Console.WriteLine();

                // 배열은 반복문 사용하면 일관적인 접근이 용이함.
                int skillNumber;

                for (skillNumber = 0; skillNumber < skillsCount; ++skillNumber)
                {
                    Console.WriteLine($"스킬 {skillNumber}: {skills[skillNumber]}");
                }

                Console.WriteLine();

                Console.Write($"사용할 스킬 번호): ");

                int.TryParse(Console.ReadLine(), out skillNumber);

                Console.WriteLine();

                Console.WriteLine($"\"{skills[skillNumber]}!\"");
            }
            #endregion

            Console.WriteLine();

            #region foreach를 사용한 방법
            {
                Console.WriteLine("[foreach를 사용한 방법]");

                Console.WriteLine();

                // foreach
                // 컬렉션(Collection)의 각 요소를 처음부터 끝까지 순차적으로 방문하여 값을 받아오는 방식의 반복문.
                // index를 사용하지 않기 때문에 필요하다면 따로 선언해줘야 함.
                int skillNumber = 0;

                // var
                // 컴파일러가 초기화 값을 통해 자료형을 자동적으로 유추하는 변수 선언 키워드(Variable Keyword)
                foreach (var skill in skills)
                {
                    Console.WriteLine($"스킬 {skillNumber++}: {skill}");
                }

                Console.WriteLine();

                Console.Write($"사용할 스킬 번호): ");

                int.TryParse(Console.ReadLine(), out skillNumber);

                Console.WriteLine();

                Console.WriteLine($"\"{skills[skillNumber]}!\"");
            }
            #endregion
        }

        // 다차원 배열 예제
        private static void MultiDimensionalArrayExample()
        {
            // 다차원 배열(Multi-Dimensional Array)
            // 배열은 또 다른 배열의 메모리를 가리킬 수 있음.

            #region n차원 배열
            {
                Console.WriteLine("[n차원 배열]");

                Console.WriteLine();

                // n차원 배열(N-Dimensional Array)
                // 대괄호 안에 쉼표(,)의 개수로 배열의 차원을 지정.
                // 각 배열의 길이가 일정해야 함.
                // 각 배열의 메모리가 연속적으로 저장됨.

                //int[,] twoDimensionalArray = new int[3, 3]
                // 아래와 같이 단순화 가능
                int[,] twoDimensionalArray =
                {
                { 0, 1, 2 },
                { 3, 4, 5 },
                { 6, 7, 8 },
            };

                // int Array.GetLength(int dimension)
                // 다차원 배열의 길이를 가져오는 함수.
                for (int i = 0; i < twoDimensionalArray.GetLength(0); ++i)
                {
                    for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                    {
                        Console.Write($"{twoDimensionalArray[i, j]} ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();

                // foreach를 사용하여 n차원 배열의 모든 요소를 순차척으로 읽기 가능.
                foreach (var element in twoDimensionalArray)
                {
                    Console.Write($"{element} ");
                }

                Console.WriteLine();
            }
            #endregion

            Console.WriteLine();

            #region 가변 배열
            {
                Console.WriteLine("[가변 배열]");

                Console.WriteLine();

                // 가변 배열(Jagged Array)
                // 대괄호의 개수로 배열의 차원을 지정.
                // 각 배열의 길이를 다르게 지정할 수 있음.
                // 각 배열의 메모리가 연속적으로 저장되지 않음.
                /*
                int[][] jaggedArray = new int[3][]
                {
                    new int[2]{ 0, 1 },
                    new int[4]{ 2, 3, 4, 5 },
                    new int[3]{ 6, 7, 8 },
                };
                */
                // 아래와 같이 단순화 가능
                int[][] jaggedArray =
                [
                    [0, 1],
                    [2, 3, 4, 5],
                    [6, 7, 8],
                ];

                // int Array.Length
                // 배열의 길이를 가져오는 속성(Auto-implemented Properties).
                for (int i = 0; i < jaggedArray.Length; ++i)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        Console.Write($"{jaggedArray[i][j]} ");
                    }

                    Console.WriteLine();
                }
            }
            #endregion
        }

        private static void StringExample()
        {
            // string은 사실 연속된 char들을 담는 컬렉션(Collection)의 일종이다.
            string numbers = "0123456789";

            foreach (char number in numbers)
            {
                Console.Write(number);
            }
        }
    }
}
