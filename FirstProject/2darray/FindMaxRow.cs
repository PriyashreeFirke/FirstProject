using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject._2darray
{
    class FindMaxRow
    {
        public static void ROWMAX(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[0, i];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])//(max>a[i,j])
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
             int[,] arr = { { 6, 3, 4 }, { 7, 3, 9 }, { 3, 2, 6 } };
            FindMaxRow.ROWMAX(arr);
        }
    }
        


    }

