using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam7
{
    class Max
    {
        public static void Rowmax(int[,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[0, i];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("rowmax=" + max);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 22, 31, 9 }, { 12, 25, 16 } };
            Max.Rowmax(arr);
        }

    }

}

