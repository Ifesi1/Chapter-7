using System;

namespace Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 1, 4, 5, 6, };
            int minValue =1;

            Console.WriteLine("The elements in the array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j]<array[i])
                    {
                        minValue = array[j];
                        array[j] = array[i];
                        array[i] = minValue;
                    }
                }
               
            }
            Console.Write(minValue + " ");
            Console.WriteLine();

        }
    }
}
