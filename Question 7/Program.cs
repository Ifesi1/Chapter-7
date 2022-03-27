using System;

namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            Console.Write("Enter the number of elements, N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrayN = new int [n];
            Console.Write("Enter a K value less than N: ");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxSum = int.MinValue;

            Console.Write("Enter the elements: ");
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                //n[i] = int.Parse(Console.ReadLine());
                for (int j = 1; j < k; j++)
                {
                    sum = arrayN[i] + arrayN[j];
                    arrayN[i + j] = arrayN[(i + 1) + (j + 1)];
                    arrayN[(i + 1) + (j + 1)] = sum;

                    if (sum>maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine();
        }
    }
}
