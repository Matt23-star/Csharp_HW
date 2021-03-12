using System;

namespace questionOne
{
    class Program
    {
        void judge(int n)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write($"{i}\t");
                    n /= i;
                }
            }
        }
    }
}
