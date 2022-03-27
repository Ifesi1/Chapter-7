using System;

namespace Question_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int s = 11;
            Console.WriteLine("The neighboring numbers are:  ");
            for (int i = 0; i < array.Length; i++)
            {
                int sum = array[i] + array[i + 1];
                array[i + 1] = array[i + 2];
                array[i + 2] = sum;

                while (sum==s)
                {sum++;
                    Console.Write(array[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
