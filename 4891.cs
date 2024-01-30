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
            int[] arr = new int[a];

            /*중요 포인트*/
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            for (int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }
            /*-----------*/

            for (int i = 0; i < a; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                }
                if (arr[i] <= min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("{0}", max - min);
        }
    }
}
