// 배열 Array
/* 
    Array의 멤버

    멤버            타입                    설명
    ===============================================================================
    Rank            인스턴스 프로퍼티       배열 인서턴스의 차원(dimention) 수를 반환
    Length          인스턴스 프로퍼티       배열 인스턴스의 요소(element) 수를 반환
    Sort            정적 메소드             배열 요소를 값의 순서대로 정렬
    GetValue        인스턴스 메서드         지정된 인덱스의 배열 요소 값을 반환
    Copy            정적 메소드             배열의 내용을 다른 배열에 복사
 */

 // 사용 예시
 using System;

 namespace ConsoleApp1
{
    class Program
    {
        private static void OutputArrayInfo(Array arr)
        {
            Console.WriteLine("배열의 차원 수:" + arr.Rank); // Rank 프로퍼티
            Console.WriteLine("배열의 요소 수:" + arr.Length); // Length 프로퍼티
            Console.WriteLine();
        }

        private static void OuptutArrayElements(string title,Array arr)
        {
            Console.WriteLine("["+title+"]");

            for (int i=0;i<arr.Length;i++)
            {
                Console.Write(arr.GetValue(i)+","); // GetValue 인스턴스 메서드
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool[,] boolArray = new bool[,] {{true,false},{false,false}};
            OutputArrayInfo(boolArray);

            int[] intArray = new int[]{5,4,3,2,1,0};
            OutputArrayInfo(intArray);

            OuptutArrayElements("원본 intArray",intArray);
            Array.Sort(intArray); // Sort 정적 메소드
            OuptutArrayElements("Array.Sort 후 intArray",intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray,copyArray,intArray.Length); // Copy 정적 메소드

            OuptutArrayElements("intArray로 부터 복사된 copyArray",copyArray);

        }
    }
}