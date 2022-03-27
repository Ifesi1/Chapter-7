using System;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20  };
            array[0] = 1; array[1] = 2; array[2] = 3; array[3] = 4; array[4] = 5; array[5] = 6; array[6] = 7;
            array[7] = 8; array[8] = 9; array[9] = 10; array[10] = 11; array[11] = 12; array[12] = 13; 
            array[13] = 14; array[14] = 15; array[15] = 16; array[16] = 17; array[17] = 18; array[18] = 19; 
            array[19] = 20;

            Console.WriteLine("The elements in the array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{");
                Console.Write(array[i]+" ");
                Console.Write("}");
            }
            Console.WriteLine("the individual products of the array elements are: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 5;
                Console.Write(" "+array[i]);
            }

            Console.WriteLine();
        }
    }
}
