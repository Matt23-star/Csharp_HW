using System;

namespace questionOne
{
    class Program
    {
        //打印链表元素
        public static void PrintAll(GenericList<int> genericList)
        {
            genericList.ForEach((i) =>
            {
                Console.Write(i + '\t');
            });
            Console.WriteLine();
        }

        //打印最大值
        public static void GetMax(GenericList<int> genericList)
        {
            int max = int.MinValue;
            genericList.ForEach((i) =>
            {
                if (i > max)
                {
                    max = i;
                }
            });
            Console.WriteLine("最大值为：" + max);
        }

        //打印最小值
        public static void GetMin(GenericList<int> genericList)
        {
            int min = int.MaxValue;
            genericList.ForEach((i) =>
            {
                if (i < min)
                {
                    min = i;
                }
            });
            Console.WriteLine("最小值为：" + min);
        }

        //打印总值
        public static void GetSum(GenericList<int> genericList)
        {
            int sum = 0;
            genericList.ForEach((i) =>
            {
                sum += i;
            });
            Console.WriteLine("总和为：" + sum);
        }

        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(1);
            genericList.Add(5);
            genericList.Add(7);
            genericList.Add(3);
            genericList.Add(13);
            genericList.Add(4);
            genericList.Add(0);
            //打印输出链表元素
            PrintAll(genericList);
            //打印最大值
            GetMax(genericList);
            //打印最小值
            GetMin(genericList);
            //打印总和
            GetSum(genericList);
        }
    }





}
