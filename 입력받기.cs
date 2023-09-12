using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string b, n;

            //문자열
            b = Console.ReadLine(); // 입력
            Console.WriteLine(b);   // 출력

            //정수
            n = Console.ReadLine(); // 입력
            a = Convert.ToInt32(n); //정수변환
            Console.WriteLine(a);    // 출력
        }
    }
}