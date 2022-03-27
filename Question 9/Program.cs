using System;

namespace Question_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int sum;
            int maxSum = 0;

            Console.WriteLine("The list of elements in array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine("The max sum of elements in the above array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    sum = array[i] + array[j];

                    if (sum>maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine("The maximum sum of the sequence is: "+maxSum);
            Console.WriteLine();
        }
    }
}
