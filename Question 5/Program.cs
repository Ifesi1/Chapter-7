using System;

namespace Q3_Trial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] lex =  { 'a', 'c', 'b', 'd' };
            Console.WriteLine("The arranged format of a, c, b and d :  ");
            for (int i = 0; i < lex.Length; i++)
            {
                if (lex[i] < lex[i+1])
                {
                    Console.Write(lex[i] + " ");
                }
                else
                {
                    Console.Write(lex[i+1] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
