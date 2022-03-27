using System;

namespace Question_5i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 3, 4, 2, 2, 4 };
            int lexico = 0;
            int container;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == ((array[i+1]) - 1))
                {
                    lexico = array[i];
                    array[i] = array[i+1]-1;
                    array[i+1]-1 = lexico;
                    Console.Write(" " + array[i]);
                }
            }
            Console.Write("Sequence of increasing numbers:  {0}",lexico);
        }
    }
}
