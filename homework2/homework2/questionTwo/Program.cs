using System;

namespace questionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 30, 4, 5, 6, 8, 2, 4 };
            int max, min;
            double sum = 0, average;
            int i = 0;
            foreach(int n in array)
            {
                sum += n;
                i++;
            }
            average = sum / i;
            min = max = array[0];
            for(int j=0;j<i;j++)
            {
                if (array[j] < min) 
                {
                    min = array[j];
                }
                else if(array[j] > max)
                {
                    max = array[j];
                }
            }
            Console.WriteLine($"最大值max = {max}，最小值min = {min}，\n平均值 = {average}，元素和 = {sum}");
        }
    }
}
