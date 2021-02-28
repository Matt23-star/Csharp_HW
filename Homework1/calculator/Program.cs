using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char c;
            Console.WriteLine("请输入第一个数字");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符");
            c = (char)Console.Read();
            switch (c)
            {
                case '+':
                    Console.WriteLine($"a{c}b={a + b}");
                    break;
                case '-':
                    Console.WriteLine($"a{c}b={a - b}");
                    break;
                case '*':
                    Console.WriteLine($"a{c}b={a * b}");
                    break;
                case '/':
                    Console.WriteLine($"a{c}b={a / b}");
                    break;
                default:
                    Console.WriteLine("数据错误，请重新输入！");
                    break;
            }
        }
    }
}
