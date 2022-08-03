using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam4
{
    class Pttern
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }




            for (i = 0; i <= 5; i++)
            {
                for (int k = i; k <= 5; k++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {

                    Console.Write(j % 2);
                }
                    Console.WriteLine();
                
            }
        }
    }
}

