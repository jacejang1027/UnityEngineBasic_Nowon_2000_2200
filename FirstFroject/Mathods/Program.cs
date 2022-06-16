using System;

namespace UnityLesson_CSharp_ClassIncludingVariableFunction
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    // Camel case  
    // class, method, namespace 등은 대문자로 시작한다. 
    // 변수는 소문자로 시작한다. 
    // 단어가 바뀔때 첫 문자는 대문자로한다. 
    // 
    // 줄임말은 되도록 사용하지 않는다. 
    // 이름을 보았을때 어떤 기능이나 목적인지 알 수 있도록 선정한다. 
    // 애매하거나 복잡한 내용이 있으면 주석을 달아준다.   


    /// <summary> 
    /// 사람 클래스다.  
    /// 말하는 기능이 있다.  
    /// </summary> 
    class Person
    {
        // bit = 한자리 이진수 ( 0과 1, 정보처리의 최소단위 ) 
        // 1 byte =  8 bit  (CPU 데이터 처리 최소단위 ) 
        // 4 byte =  8 bit * 4 = 32 bit 
        // 4 byte로 표현할수 있는 숫자의 범위 -> 2^32 
        int age; // 정수형 , 4byte -2147483648~2147483647 
        float height; // 실수형 , 4byte 
        bool isFemale; // 논리형 (참과 거짓), 1 byte 
        char genderChar; // 문자형, 2 byte 
        string name; //문자열 , 문자갯수 * 2byte   

        // 이 사람에 대한 모든 정보를 말한다 

        void SayAllInfo()
        {
            SayAge();
            SayHeight();
            SayIsFemale();
            SayGenderChar();
            SayName();
        }

        void SayAge()
        {
            Console.WriteLine(age);
        }

        void SayHeight()
        {
            Console.WriteLine(height);
        }

        void SayIsFemale()
        {
            Console.WriteLine(isFemale);
        }

        void SayGenderChar()
        {
            Console.WriteLine(genderChar);
        }

        void SayName()
        {
            Console.WriteLine(name);
        }
    }
}