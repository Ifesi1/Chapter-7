using System;

namespace Question_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int sameElementOccur;
            Console.WriteLine("The elements of the array are: ");
            foreach (var item in array)
            {
                Console.Write(array+" ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array[i+1])
                {
                    sameElementOccur = +array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
