using System;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class genshin
    {
        public int 레진;
        public int 선계화폐;
        public int 일퀘;

        public int 전리품 = 0;
        public int 누적화폐 = 0;
        public int 원석 = 0;

        public void play()
        {
            원석 += 90; //공월
            while (레진 >= 20)
            {
                레진 -= 20;
                전리품++;
            }
            누적화폐 = 선계화폐;
            선계화폐 = 0;
            if (일퀘 == 4)
            {
                원석 += 20;
            }
            while (일퀘 > 0)
            {
                일퀘--;
                원석 += 10;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            genshin 원신 = new genshin();

            Console.Write("레진수: ");
            int ra = int.Parse(Console.ReadLine());
            원신.레진 = ra;

            Console.Write("화폐수: ");
            int hw = int.Parse(Console.ReadLine());
            원신.선계화폐 = hw;

            Console.Write("일퀘수(최대4개): ");
            int ei = int.Parse(Console.ReadLine());
            if (ei > 4)
            {
                Console.WriteLine("내가 4개까지만 하랬지");
                Environment.Exit(0);

            }
            원신.일퀘 = ei;

            원신.play();

            Console.WriteLine("번 전리품수: {0}, 번 화폐수: {1}, 번 원석수: {2}", 원신.전리품, 원신.누적화폐, 원신.원석);
        }
    }
}