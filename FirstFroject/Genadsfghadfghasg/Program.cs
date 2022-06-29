using System;
using System;

// Generic : 일반화
// 다양한 자료형에 대해서 유동적으로 갖다 쓸 수 있도록 만드는 형태
// 1 + 1 + 1 + 1 + 1
// 2 + 2 + 2 + 2 + 2
// 3 + 3 + 3 + 3 + 3
// 4 + 4 + 4 + 4 + 4

// n + n + n + n + n

namespace GenericCollections
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // 박싱 : 자료형을 객체타입으로 변화하는 과정
            // 언박싱 : 객체타입을 원래 자료형으로 변환하는 과정
            // System.Collections 를 더이상 사용하지 않는 이유는
            // 박싱은 기본형 단순 할당과정보다 20 배정도 느리고
            // 언박싱은 4배정도 느리기때문에
            // Generic 을 사용할것을 권장하고 있다.
            System.Console.ArrayList arrList = new System.Collections.ArrayList();
            arrList.Add(3);
            arrList.Add();

            // List
            //-------------------------------------------------
            List<int> list_int = new List<int>();
            List<float> list_float = new List<float>();
            List<List<int>> list_list_int = new List<List<int>>();
            

            // 추가
            list_int.Add(0);
            list_float.Add(1.0f);
            list_list_int.Add(list_int);
            list_list_int.Add(new List<int>());

            // 삭제
            list_int.Remove(0);
            list_float.Remove(0);

            // 검색
            //list_int.Find(x => x == 0);
            list_int.Contains(0);

            // LinkedList
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(0);
            linkedList.AddFirst(1);
            linkedList.AddBefore(linkedList.Find(0), 3);
            Console.WriteLine(linkedList.First);
            linkedList.RemoveLast();

            // HashTable (박싱/ 언박싱 때문에 쓰지않음)
            //-------------------------------------------------
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add("철수", 90);

            // Dictionary
            Dictionary<string, char> grades = new Dictionary<string, char>();

            // 추가
            grades.Add("철수", 'A');
            grades.Add("영희", 'B');
            grades.Remove("철수");
            grades.TryAdd("영희", 'C');
            if (grades.TryAdd("영희", 'C'))
            {
                Console.WriteLine("영희점수 C 추가");
            }
            else
            {
                Console.WriteLine($"영희 점수 이미 있음 : {grades["영희"]}");
            }

            foreach (var sub in grades)
            {
                Console.WriteLine(sub.Key);
                Console.WriteLine(sub.Value);
            }
            if (grades.ContainsKey("영희"));
            {
                Console.WriteLine("영희 점수 있음");
            }
            if (grades.TryGetValue("영희", out char grade))
            {
                Console.WriteLine(grade);
            }



            // Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1); // queue 제일 뒤에 아이템 추가
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue(); // queue 제일 앞에있는 아이템 반환 및 추가
            Console.WriteLine(queue.Dequeue());
            queue.Peek();
            queue.TryPeek(out int peek);

            // Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Pop();

        }
    }
}