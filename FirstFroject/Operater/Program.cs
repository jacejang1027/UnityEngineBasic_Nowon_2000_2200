﻿using System;

namespace Operators
{

    internal class Program
    {
        static int a = 14;
        static int b = 6;
        static int c;

        static void Main(string[] args)
        {
            // 산술 연산
            // 더하기, 빼기, 곱하기, 나누기, 나머지
            //======================================================

            // 더하기
            c = a + b;
            Console.WriteLine(c);

            // 빼기
            c = a - b;
            Console.WriteLine(c);

            // 곱하기
            c = a * b;
            Console.WriteLine(c);

            // 나누기 : 정수간의 나눗셈은 정수 몫만 반환, 실수간의 나눗셈은 소숫점
            c = a / b;
            Console.WriteLine(c);

            // 나머지 : 정수연산시의 정수몫을 왼쪽 피연산자에 뺀 값을 반환
            c = a % b;
            Console.WriteLine(c);

            // 증가 연산
            ++c; // 전위 연산 : 해당 라인에서 연산을 먼저 수행한 후에 명령실행
            c++; // 후위 연산 : 해당 라인에서 명령을 먼저 수행한 후에 연산실행
            Console.WriteLine(++c);
            Console.WriteLine(c++);
            Console.WriteLine(c);
            // 감소 연산
            --c; // 전위 연산
            c--; // 후위 연산

            // 관계 연산
            // 같은, 다름, 크기 비교 연산자
            // 관계연산자의 연산결과가 참이면 true, 거짓이면 false 를 반환
            //===============================================================

            // 같음 비교
            Console.WriteLine(a == b);

            // 다름 비교
            Console.WriteLine(a != b);

            // 큰지 비교
            Console.WriteLine(a > b);

            // 크거나 같은 비교
            Console.WriteLine(a >= b);

            // 작은지 비교
            Console.WriteLine(a < b);

            // 작거나 같은 비교
            Console.WriteLine(a <= b);


            // 대입 연산자
            // 더해서 / 빼서 / 나누어서 / 곱해서 / 나머지를 대입하는 연산자
            //===============================================================
            c = 20;
            c += b; // c = c + b;
            c -= b;
            c /= b;
            c *= b;
            c %= b;

            // 논리 연산자
            // or , and, xor ,not
            //===============================================================
            bool A = true;
            bool B = false;

            // or
            // a 와 b 둘중 하나라도 true. 면 true 반환, 나머지경우 false 반환
            Console.WriteLine(A | B);

            // and
            // a 와 b 둘다 true 이면 true 반환, 나머지경우 false 반환
            Console.WriteLine(A & B);

            // xor 
            // a 와 b 둘중 하나만 true 면 true 반환 나머지경우 false 반환
            Console.WriteLine(A ^ B);

            // not
            // 피연산자가 true 이면 false, false 이면 true 반환
            Console.WriteLine(!A);
            Console.WriteLine(A);

            // 조건부 논리연산자
            // 조건부 or , 조건부 and 
            //===============================================================

            // 조건부 or
            Console.WriteLine(A || B);

            // 조건부 and 
            Console.WriteLine(A && B);

            // 비트 연산 
            // 비트연산 하는 이유 : 데이터를 효율적으로 관리하기 위함  
            // or, and, xor , not shift-left, shift-right 
            int howManyBitYouWantToShift = 1;
            // or 
            Console.WriteLine(a | b);
            // and 
            Console.WriteLine(a & b);
            // xor 
            Console.WriteLine(a ^ b);
            // not 
            Console.WriteLine(~a);
            // shift- left 
            Console.WriteLine(a << howManyBitYouWantToShift);
            // shift- right 
            Console.WriteLine(a >> howManyBitYouWantToShift);
        }
    }
}