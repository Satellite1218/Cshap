using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, max = 0, min = 1000;
            string n = Console.ReadLine();
            a = int.Parse(n);
            if (a % 4 == 0 && a % 100 != 0)
            {
                Console.WriteLine("Leap");
            }
            else if (a % 400 == 0)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Normal");
            }
        }
    }
}
