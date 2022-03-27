using System;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vs = { 1, 1, 2, 3, 2, 2, 2 };
            int lex;
            int container = 1;

            for (int i = 0; i < vs.Length-1; i++)
            {
                if (vs[i] == vs[i + 1])
                {
                    lex = vs[i];
                    vs[i] = vs[i + 1];
                    vs[i + 1] = lex;

                    if (lex > (container))
                    {
                        Console.Write(lex);
                        lex++;
                    }
                }
            }

           

            //int[] vs = { 1, 1, 2, 3, 2, 2, 2 };

            //for (int i = 0; i < vs.Length; i++)
            //{
            //    if (vs[i] == vs[i + 1] && vs[i] == vs[i + 2])
            //    {
            //        Console.Write("The maximal sequece of numbers are: {0},{1},{2} "+vs[i]);
            //    }
            //}
            //Console.WriteLine();
        }
    }
}
