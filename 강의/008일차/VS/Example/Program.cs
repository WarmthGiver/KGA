using System;

using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ThreadExample();
            //IntegerPromotionExample();
            //FunctionExample1();
            //ParameterExample1();
            //ReturnValueExample();
            //FuncionExample2();
            //OutExample();
            //RefExample();
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
                Console.WriteLine("Hello, world!");
                Console.WriteLine();

                Thread.Sleep(1000);
            }
        }

        // 정수의 승격 예제
        private static void IntegerPromotionExample()
        {
            Console.Write("마름모 높이 입력: ");
            int.TryParse(Console.ReadLine(), out var height);
            Console.WriteLine();

            Console.Write("마름모 너비 입력: ");
            int.TryParse(Console.ReadLine(), out var width);
            Console.WriteLine();

            // 정수의 승격
            // 실수에 정수를 대입하거나, 실수와 정수를 연산하면 정수가 실수형 타입으로 묵시적인 형변환이 이루어진다.
            // 따라서 식에서 정수 하나에만 실수로 형번환을 해주어도 식이 성립한다.
            var area = (double)height * width / 2;

            Console.WriteLine($"마름모 넓이: {area}");
        }

        #region 함수 예제 1
        private static void FunctionExample1()
        {
            // 함수(Function)
            //
            // 코드의 재사용성과 가독성을 항상

            WriteLineHelloWorld();
            WriteLineHelloWorld();
            WriteLineHelloWorld();
            Console.WriteLine();
        }

        private static void WriteLineHelloWorld()
        {
            Console.WriteLine("Hello, world!");
        }
        #endregion

        #region 매개변수 예제 1
        private static void ParameterExample1()
        {
            // 매개변수(Parameter)
            // 

            WriteLine("Hello, world!");
            Console.WriteLine();

            WriteLineNameAndAge("이시온", 27);
            Console.WriteLine();

            WriteLineNumbers(1, 2, 3, 4, 5);
            Console.WriteLine();
        }

        private static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        private static void WriteLineNameAndAge(string name, int age)
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"나이: {age}");
        }

        private static void WriteLineNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
        #endregion

        #region 반환 값 예제
        private static void ReturnValueExample()
        {
            // 반환 값(Return Value)
            //

            Console.Write("텍스트 입력: ");
            string text = ReadLine();
            Console.WriteLine();

            Console.Write("텍스트 출력: ");
            Console.WriteLine(text);
        }        

        private static string ReadLine()
        {
            return Console.ReadLine();
        }
        #endregion

        #region 함수 예제 2
        private static void FuncionExample2()
        {
            Console.Write("마름모 너비 입력: ");
            int.TryParse(Console.ReadLine(), out var width);
            Console.WriteLine();

            Console.Write("마름모 높이 입력: ");
            int.TryParse(Console.ReadLine(), out var height);
            Console.WriteLine();

            double rhombusArea = GetRhombusArea(width, height);

            Console.WriteLine($"마름모 넓이: {rhombusArea}");
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

            Console.Write("피제수: ");
            double.TryParse(Console.ReadLine(), out var dividend);
            Console.WriteLine();

            Console.Write("제수: ");
            double.TryParse(Console.ReadLine(), out var divisor);
            Console.WriteLine();

            if (TryDivide(dividend, divisor, out double quotient))
            {
                Console.WriteLine($"몫: {quotient}");
            }

            else
            {
                Console.WriteLine("0으로 나눌 수 없습니다.");
            }
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

            Console.WriteLine($"left = {left}, right = {right}");
            Console.WriteLine();

            Swap(left, right);

            Console.WriteLine("Swap1(left, right)");
            Console.WriteLine();

            Console.WriteLine($"left = {left}, right = {right}");
            Console.WriteLine();

            SwapByRef(ref left, ref right);

            Console.WriteLine("Swap2(ref left, ref right)");
            Console.WriteLine();

            Console.WriteLine($"left = {left}, right = {right}");
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

            Console.Write("array = ");
            WriteLineArray(array);
            Console.WriteLine();

            Console.WriteLine("SetArray0(array);");
            Console.WriteLine();

            SetArray0(array);

            Console.Write("array = ");
            WriteLineArray(array);
        }

        private static void WriteLineArray(int[] array)
        {
            Console.Write("{ ");
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine('}');
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