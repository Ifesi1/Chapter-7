using System;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number in your first array:  ");
            int a1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[a1];

            Console.Write("Please enter a number in your second array:  ");
            int a2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[a2];

            
            if (array1.Length == array2.Length)
            {
                Console.WriteLine("Both Arrays are equal");
            }
            else
            {
                Console.WriteLine("They are not equal, try another again!");
            }
            Console.WriteLine();
        }
    }
}
