using System;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lexico = ' ';
            char[] firstCharArray = new char[]{'b', 'a', 'f', 'e', 'd', 'c'};
            char[] secondCharArray = new char[]{'g', 'h', 'i', 'j', 'k', 'l'};
            Console.WriteLine("The first character elements are:  ");
            for (int i = 0; i < firstCharArray.Length; i++)
            {
                Console.Write(firstCharArray[i]+" ");
            }
            Console.WriteLine("The second character elements are:  ");
            for (int i = 0; i < secondCharArray.Length; i++)
            {
                Console.WriteLine(secondCharArray[i]+" ");
            }

            if (firstCharArray.Length < secondCharArray.Length)
            {
                Console.WriteLine("The first Char Array comes first lexicographically");

            }
            else if(firstCharArray.Length>secondCharArray.Length)
            {
                Console.WriteLine("The second Char Array comes first lexicographically");
            }
            else
            {
                for (int i = 0; i < firstCharArray.Length; i++)
                {
                    if (firstCharArray[i] < secondCharArray[i])
                    {
                        Console.WriteLine("The first Char Array comes first lexicographically");
                    }
                    if (secondCharArray[i] < firstCharArray[i])
                    {
                        Console.WriteLine("The second Char Array comes first lexicographically");
                    }
                    else
                    {
                        Console.WriteLine("The two Arrays are lexicographically equal");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
