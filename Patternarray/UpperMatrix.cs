using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Patternarray
{
    class UpperMatrix
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        Console.WriteLine("enter element");
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("............");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
