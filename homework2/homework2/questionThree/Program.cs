using System;

namespace questionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int top1 = -1, top2 = -1;
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            for(int i=2;i<=100;i++)
            {
                top1++;
                array1[top1] = i;
            }
            for (int j = 2;j<100;j++)
            {
                while (top1!=-1)
                {
                    if (array1[top1] % j == 0 && array1[top1] == j)
                    {
                        top2++;
                        array2[top2] = array1[top1];
                        top1--;
                    }
                    else if (array1[top1] % j != 0)
                    {
                        top2++;
                        array2[top2] = array1[top1];
                        top1--;
                    }
                    else
                        top1--;
                }
                int length = top2;
                for (int k = 0; k < length; k++)
                {
                    top1++;
                    array1[top1] = array2[top2];
                    top2--;
                }
            }
            Console.WriteLine("素数有：");
            for(int j=1; j <top1+2;j++)
            {
                Console.Write($"{array1[j-1]}\t");
                if (j % 5 == 0)
                    Console.Write("\n");
            }
        }
    }
}
