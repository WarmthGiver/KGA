/*
이름: 이시온
날짜: 24.11.29

**심화 과제 3. 피보나치 함수 제작**

- 피보나치 수란, 맨 첫째와 둘째 항은 각각 1이지만, 그 뒤로 오는 모든 항은 앞의 두 항의 합인 수열입니다. 예를 들어 [1,1,2,3,5,8,...] 이렇게 4번째(3) 항목은 2번째(1)와 3번째(2)의 합이고, 마찬가지로 6번째(8) 항목은 바로 앞 4번째(3), 5번째(5)의 합인 형태입니다. 함수의 인자값으로 '몇번째' 인지 정수로 건네주면, 일치하는 피보나치 수를 반환하는 함수를 제작하세요. 참고로 11번째 피보나치 수는 89, 20번째 피보나치 수는 6765 입니다.
*/

using System;

namespace Assignment3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string passage = "**심화 과제 3. 피보나치 함수 제작**\r\n\r\n- 피보나치 수란, 맨 첫째와 둘째 항은 각각 1이지만, 그 뒤로 오는 모든 항은 앞의 두 항의 합인 수열입니다. 예를 들어 [1,1,2,3,5,8,...] 이렇게 4번째(3) 항목은 2번째(1)와 3번째(2)의 합이고, 마찬가지로 6번째(8) 항목은 바로 앞 4번째(3), 5번째(5)의 합인 형태입니다. 함수의 인자값으로 '몇번째' 인지 정수로 건네주면, 일치하는 피보나치 수를 반환하는 함수를 제작하세요. 참고로 11번째 피보나치 수는 89, 20번째 피보나치 수는 6765 입니다.";

            Console.WriteLine(passage);
            Console.WriteLine();

            Console.Write("정수 입력(): ");
            byte.TryParse(Console.ReadLine(), out var n);
            Console.WriteLine();

            ulong[] result = GetFibonacciNumber(n);

            Console.Write($"{n}번째 피보니치 수: ");

            foreach (ulong element in result)
            {
                Console.Write(element);
            }

            // 93 이상 입력하면 값이 이상하게 나옴
            // ulong의 최대 크기: 18,446,744,073,709,551,615
            // 94번째 파보니치 수: 19,740,274,219,868,223,167
            /*
            ulong result = GetFibonacciNumber(n);

            Console.Write($"{n}번째 파보니치 수: {result}");
            */
        }
        
        private static ulong[] GetFibonacciNumber(byte n)
        {
            ulong[] result;

            // 8byte * 1,000,000 = 80MB
            const int maxSize = 10000000;

            // 8byte * int.MaxValue(2,147,483,647) = 17,179,869,176byte(약 17GB)
            // 메모리만 충분하다면 이론상 가능
            // 최대로 표현 가능한 수: 39,614,081,238,685,424,720,914,939,905
            // 138번째 피보나치 수: 30,960,598,847,965,113,057,878,492,344
            //const int maxSize = int.MaxValue;

            int size = 1;

            ulong[] current = new ulong[maxSize];

            ulong[] current_old = new ulong[maxSize];

            ulong[] increment = new ulong[maxSize];

            current[0] = 0;

            increment[0] = 1;

            while (n-- != 0)
            {
                ulong carry = 0;

                CopyArray(current_old, current, size);

                for (int i = 0; i < size; ++i)
                {
                    current[i] += increment[i] + carry;

                    carry = current[i] / maxSize;

                    current[i] %= maxSize;
                }

                CopyArray(increment, current_old, size);

                if (carry > 0)
                {
                    current[size] = carry;

                    increment[size] = 0;

                    ++size;

                    if (size == maxSize)
                    {
                        break;
                    }
                }
            }

            result = new ulong[size];

            for (int i = 0, j = size - 1; i < size; ++i, --j)
            {
                result[i] = current[j];
            }

            return result;
        }

        private static void CopyArray(ulong[] left, ulong[] right, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                left[i] = right[i];
            }
        }
        /*
        private static ulong GetFibonacciNumber(ulong n)
        {
            ulong current = 0;

            ulong current_old;

            ulong increment = 1;

            for (ulong i = 0; i < n; ++i)
            {
                current_old = current;

                current += increment;

                increment = current_old;
            }

            return current;
        }
        */
    }
}