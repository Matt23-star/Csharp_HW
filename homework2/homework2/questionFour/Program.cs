using System;
/*如果矩阵上每一条由左上到右下的对角线上的元素都相同，
那么这个矩阵是托普利茨矩阵 。
给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。*/

namespace questionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1,2,3,4 },
                                { 5,1,2,3 },
                                { 9,5,1,2 }};
            if (Program.Judge(array))
            {
                Console.WriteLine("是托普利茨矩阵");
            }
            else
                Console.WriteLine("不是托普利茨矩阵");
        }

        static bool Judge(int [,]array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    if (i != 0 && j != 0 && array[i,j] != array[i - 1,j - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
