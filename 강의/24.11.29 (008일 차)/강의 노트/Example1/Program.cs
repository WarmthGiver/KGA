/*
이름: 이시온
날짜: 24.11.29
*/

using System;
using System.Threading;

namespace Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ThreadExample();
            IntegerPromotionExample();
            FunctionExample1();
            ParameterExample1();
            ReturnValueExample();
            FuncionExample2();
            OutExample();
            RefExample();
            ParameterExample2();
        }

        // 쓰레드 예제
        private static void ThreadExample()
        {
            // 쓰레드(Thread)
            // 

            // void Thread.Sleep(int millisecondsTimeout);
            // 

            while (true)
            {
                Console.WriteLine();
                Console.Write("Hello, world!");
                Console.WriteLine();

                Thread.Sleep(1000);
            }
        }

        // 정수의 승격 예제
        private static void IntegerPromotionExample()
        {
            Console.WriteLine();
            Console.Write("마름모 높이 입력: ");
            int.TryParse(Console.ReadLine(), out var height);

            Console.WriteLine();
            Console.Write("마름모 너비 입력: ");
            int.TryParse(Console.ReadLine(), out var width);

            // 정수의 승격
            // 실수에 정수를 대입하거나, 실수와 정수를 연산하면 정수가 실수형 타입으로 묵시적인 형변환이 이루어진다.
            // 따라서 식에서 정수 하나에만 실수로 형번환을 해주어도 식이 성립한다.
            var area = (double)height * width / 2;

            Console.WriteLine();
            Console.Write($"마름모 넓이: {area}");
            Console.WriteLine();
        }

        #region 함수 예제 1
        private static void FunctionExample1()
        {
            // 함수(Function)
            //
            // 코드의 재사용성과 가독성을 항상

            Console.WriteLine();
            WriteHelloWorld();
            Console.WriteLine();

            Console.WriteLine();
            WriteHelloWorld();
            Console.WriteLine();

            Console.WriteLine();
            WriteHelloWorld();
            Console.WriteLine();
        }

        private static void WriteHelloWorld()
        {
            Console.Write("Hello, world!");
        }
        #endregion

        #region 매개변수 예제 1
        private static void ParameterExample1()
        {
            // 매개변수(Parameter)
            // 

            Console.WriteLine();
            Write("Hello, world!");
            Console.WriteLine();

            Console.WriteLine();
            WriteNameAndAge("이시온", 27);
            Console.WriteLine();

            Console.WriteLine();
            WriteNumbers(1, 2, 3, 4, 5);
            Console.WriteLine();
        }

        private static void Write(string text)
        {
            Console.Write(text);
        }

        private static void WriteNameAndAge(string name, int age)
        {
            Console.Write($"이름: {name}\n");
            Console.WriteLine();
            Console.Write($"나이: {age}");
        }

        private static void WriteNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
        #endregion

        #region 반환 값 예제
        private static void ReturnValueExample()
        {
            // 반환 값(Return Value)
            //

            Console.WriteLine();
            Console.Write("텍스트 입력: ");
            string text = ReadLine();

            Console.WriteLine();
            Console.Write($"텍스트 출력: {text}");
            Console.WriteLine();
        }        

        private static string ReadLine()
        {
            return Console.ReadLine();
        }
        #endregion

        #region 함수 예제 2
        private static void FuncionExample2()
        {
            Console.WriteLine();
            Console.Write("마름모 너비 입력: ");
            int.TryParse(Console.ReadLine(), out var width);
            
            Console.WriteLine();
            Console.Write("마름모 높이 입력: ");
            int.TryParse(Console.ReadLine(), out var height);

            double rhombusArea = GetRhombusArea(width, height);

            Console.WriteLine();
            Console.Write($"마름모 넓이: {rhombusArea}");
            Console.WriteLine();
        }

        private static double GetRhombusArea(int width, int height)
        {
            return (double)width * height / 2;
        }
        #endregion

        #region out 예제
        private static void OutExample()
        {
            // out
            //

            Console.WriteLine();
            Console.Write("피제수: ");
            double.TryParse(Console.ReadLine(), out var dividend);

            Console.WriteLine();
            Console.Write("제수: ");
            double.TryParse(Console.ReadLine(), out var divisor);

            Console.WriteLine();
            if (TryDivide(dividend, divisor, out double quotient))
            {
                Console.Write($"몫: {quotient}");
            }
            else
            {
                Console.Write("0으로 나눌 수 없습니다.");
            }
            Console.WriteLine();
        }

        private static bool TryDivide(double dividend, double divisor, out double outValue)
        {
            if (divisor == 0)
            {
                outValue = 0;

                return false;
            }

            outValue = dividend / divisor;

            return true;
        }
        #endregion

        #region ref 예제
        private static void RefExample()
        {
            // ref(Reference)
            // 참조에 의한 전달(Pass by Reference)을 위한 키워드.
            // 기본적으로 C#의 메서드에서 매개변수를 전달할 때 값에 의한 전달(Pass by Value)이 이루어지는데,
            // 변수의 참조를 직접 전달하여 호출된 메서드에서 원본 변수를 수정할 수 있음.

            int left = 0, right = 1;

            Console.WriteLine();
            Console.Write($"left = {left}, right = {right}");
            Console.WriteLine();

            Swap(left, right);

            Console.WriteLine();
            Console.Write("Swap1(left, right)");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"left = {left}, right = {right}");
            Console.WriteLine();

            SwapByRef(ref left, ref right);

            Console.WriteLine();
            Console.Write("Swap2(ref left, ref right)");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write($"left = {left}, right = {right}");
            Console.WriteLine();
        }

        private static void Swap(int left, int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        private static void SwapByRef(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
        #endregion

        #region 매개변수 예제 2
        private static void ParameterExample2()
        {
            // 배열 매개변수
            // 

            int[] array = [1, 2, 3];

            Console.WriteLine();
            Console.Write("array = ");
            WriteArray(array);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("SetArray0(array);");
            Console.WriteLine();

            SetArray0(array);

            Console.WriteLine();
            Console.Write("array = ");
            WriteArray(array);
            Console.WriteLine();
        }

        private static void WriteArray(int[] array)
        {
            Console.Write("{ ");
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
            Console.Write('}');
        }

        private static void SetArray0(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; --i)
            {
                array[i] = 0;
            }
        }
        #endregion
    }
}