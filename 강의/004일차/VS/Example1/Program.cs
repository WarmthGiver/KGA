#pragma warning disable

/*
 * 이름: 이시온
 * 날짜: 2024.11.25
 */

using System;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //WriteConsoleExample();
            //NamespaceExample();
            //WriteConsoleMyInitial();
            //WriteConsoleTetrisBlocks();
            //VariableExample();
            //ElementaryArithmeticExample();
            //ReadConsoleExample();
            //SumStringExample();
            //ParseExample();
            //ParseWithReadLineExample();
            TryParseWithReadLineExample();
        }

        private static void WriteConsoleExample()
        {
            // Ctrl + K + C: 여러 줄 주석
            // Ctrl + K + U: 여러 줄 해제
            // Ctrl + K + F: 자동 들여쓰기

            // Console.Write: 콘솔창에 문자열 출력
            Console.Write("안녕하세요. ");

            // '\n': 문자열 줄 바꿈
            Console.Write("제 이름은\n");

            // Console.WriteLine: 콘솔창에 문자열 출력 후 줄 바꿈
            Console.WriteLine("시온 입니다.\n");

            // '\': 따옴표(', "), 역슬래시(\) 등의 문자를 입력할 때 해당 문자 앞에 '\'를 붙임
            Console.WriteLine("\'\\\'\': \'");
            Console.WriteLine("\'\\\"\': \"");
            Console.WriteLine("\'\\\\\': \\\n");

            // 자리표시자("{0}"): 문자열에서 index를 중괄호로 감싸면 index에 해당하는 매개 변수가 문자열에 삽입됨
            Console.WriteLine("0, {0}, {1}, {2}, 4\n", 1, 2, 3);
        }

        private static void NamespaceExample()
        {
            // using System;을 선언하지 않아도 System.Console을 참조 가능
            System.Console.WriteLine("System.Console.WriteLine");

            // namespace가 다르면 Class 이름이 중복되어도 사용 가능
            ZL.Temp a;
            BJH.Temp b;
        }

        private static void WriteConsoleMyInitial()
        {
            Console.WriteLine("■■■□■□□");
            Console.WriteLine("□□■□■□□");
            Console.WriteLine("□■□□■□□");
            Console.WriteLine("■□□□■□□");
            Console.WriteLine("■■■□■■■");
        }

        private static void WriteConsoleTetrisBlocks()
        {
            Console.WriteLine("■");
            Console.WriteLine("■■■");
            Console.WriteLine();
            Console.WriteLine("■■");
            Console.WriteLine("■■");
            Console.WriteLine();
            Console.WriteLine("■■");
            Console.WriteLine("　■■");
        }

        private static void VariableExample()
        {
            #region 명명 규칙(Naming Convention)

            // Pascal Case: 단어의 첫 글자만 대문자
            // 주로 Namespace나 Class, Method의 이름에 사용
            int PascalCase;

            // Camel Case: 첫 번째 단어의 첫 글자는 소문자, 나머지 단어의 첫 글자는 대문자
            // 주로 변수명에 사용
            int camelCase;

            #endregion

            #region int, const int

            // 정수 타입(integer) 변수 선언
            // 범위: -2,147,483,648 ~ 2,147,483,647
            // 크기: 4byte
            int @int;

            // 변수 a에 10을 대입
            @int = 1;

            // 정수 타입(integer) 상수 b를 선언
            const int constInt = 2;

            // 오류 발생. 상수는 값을 바꿀 수 없음
            //b = 3;

            #endregion

            #region byte

            // 정수 타입(byte) 변수 선언
            // 범위: 0 ~ 255
            // 크기: 1byte
            byte @byte;

            #endregion

            #region short

            // 정수 타입(short) 변수 선언
            // 범위: -32,768 ~ 32,767
            // 크기: 2byte
            short @short;

            #endregion

            #region long

            // 정수 타입(integer) 변수 a를 선언
            // 범위: -922,337,203,685,477,508 ~ 922,337,203,685,477,507
            // 크기: 8byte
            long @long;

            #endregion

            #region char

            // 문자 타입(character) 변수 선언
            // 범위:  문자 하나만 저장
            // 크기: 2byte
            char @char;

            #endregion

            #region string

            // 문자열 타입(string) 변수 선언
            // 범위: 문자 여러개를 저장
            // 크기: 문자 길이에 따라 다름
            string @string;

            #endregion

            #region float

            // 실수 타입(float) 변수 선언
            // 범위: 3.4E +/- 38(소숫점 7자리 까지)
            // 크기: 4byte
            float @float;

            #endregion

            #region double

            // 실수 타입(double) 변수 선언
            // 범위: 1.7E +/- 308(소숫점 15~16자리 까지)
            // 크기: 8byte
            double @double;

            #endregion
        }

        private static void ElementaryArithmeticExample()
        {
            int first = 1, second = 2;

            Console.WriteLine("{0} = 1", nameof(first));

            Console.WriteLine("{0} = 2", nameof(second));

            Console.WriteLine();

            // 더하기
            Console.WriteLine("{0} + {1} = {2}", first, second, first + second); // = 3

            // 빼기
            Console.WriteLine("{0} - {1} = {2}", first, second, first - second); // = -1

            // 곱하기
            Console.WriteLine("{0} * {1} = {2}", first, second, first * second); // = 2

            // 나누기
            Console.WriteLine("{0} / {1} = {2}", first, second, first / second); // = 0

            // 나머지
            Console.WriteLine("{0} % {1} = {2}", first, second, first % second); // = 2

            Console.WriteLine();

            // 연산자 우선순위: 
            Console.WriteLine("{0} * 3 + {1} = {2}", first, second, first * 3 + second); // = 5

            Console.WriteLine();

            // 복합대입연산자
            // first = first + second 와 같음
            first += second;

            Console.WriteLine("{0} += {1}", nameof(first), nameof(second));
            Console.WriteLine("{0} = {1}", nameof(first), first); // = 3

            Console.WriteLine();

            // 증감 연산자
            ++first;

            Console.WriteLine("++{0}", nameof(first));
            Console.WriteLine("{0} = {1}", nameof(first), first); // = 4
        }

        private static void ReadConsoleExample()
        {
            string input;

            Console.Write("텍스트 입력: ");

            // Console.ReadLine: 콘솔창 입력 함수
            input = Console.ReadLine();

            Console.WriteLine("텍스트 출력: {0}", input);

            Console.Write("텍스트 입력: ");

            input = Console.ReadLine();

            // 문자열 보간($"{}"): 문자열 앞에 $를 추가하면 중괄호 안에 변수를 넣을 수 있음
            Console.WriteLine($"텍스트 출력: {input}");
        }

        private static void SumStringExample()
        {
            string text = "문자열";

            // 문자열 + 문자열
            Console.WriteLine($"{text} + {text} = {text + text}");

            // 문자열 + 정수
            Console.WriteLine($"{text} + 1 = {text + 1}");
        }

        private static void ParseExample()
        {
            // int.Parse: 문자열을 4바이트 크기의 정수로 변환
            int value = int.Parse("123");

            // value 출력
            Console.WriteLine($"value = {value}");
        }

        private static void ParseWithReadLineExample()
        {
            Console.Write("Parse To Int (범위 -2,147,483,648 ~ 2,147,483,647): ");

            // 문자열 입력
            string input = Console.ReadLine();

            // 입력 받은 문자열을 4바이트 크기의 정수로 변환
            int value = int.Parse(input);

            // value 출력
            Console.WriteLine($"value = {value}");
        }

        private static void TryParseWithReadLineExample()
        {
            Console.Write("Try Parse To int (범위 -2,147,483,648 ~ 2,147,483,647): ");

            // 문자열 입력
            string input = Console.ReadLine();

            int value;

            // int.TryParse:
            // 문자열이 유효하다면 정수로 변환하여 value에 대입후 true 반환
            // 유효하지 않다면 value에 0 대입후 false 반환
            bool isValid = int.TryParse(input, out value);

            // 문자열이 유효하다면
            if (isValid)
            {
                // 대입받은 value를 출력
                Console.WriteLine($"value = {value}");
            }
            // 유효하지 않다면
            else
            {
                // 에러 텍스트 출력
                Console.WriteLine("올바른 값이 아닙니다.");
            }
        }

        private static void DivisionExample()
        {
            int reward = 9;

            int personCount = 4;

            // 타입(형)변환: 괄호 안에 타입 넣어서 변수 앞에 써줌으로써 일시적으로 타입을 바꿔줌
            float result = (float)reward / personCount;
        }
    }
}

namespace ZL // 이시온
{
    internal class Temp
    {

    }
}

namespace BJH // 박지환
{
    internal class Temp
    {

    }
}