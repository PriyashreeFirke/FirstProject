using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject._2darray
{
    class Add
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 4, 7, 2 }, { 3, 4, 8 }, { 4, 6, 2 } };
            int[,] arr1 = { { 6, 3, 2 }, { 2, 4, 6 }, { 3, 6, 9 } };
            int[,] arr3 = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr3[i, j] = arr[i, j] + arr1[i, j];
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
