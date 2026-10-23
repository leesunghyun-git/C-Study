using System;

namespace ConsoldeApp1
{
    class Mathematics
    {
        public int GetAreaOfSquare(int x)
        {
            return x * x ;
        }

        public int GetValue() // 매개 변수는 없고 값만 변환
        {
            return 10;
        }
        // 2개의 매개변수를 받고, 반환값이 없음

        public void Output(String prefix, int value)
        {
            Console.WriteLine(prefix + value);
        }
    }

    /* class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.GetAreaOfSquare(m.GetValue());

            m.Output("결과 :",result);
        }
    } */
}