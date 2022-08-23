using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject._2darray
{
    class Average
    {
        public static void Avrageofrow(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                float avgrow = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    avgrow = avgrow + a[3, 3];
                }
                avgrow = avgrow / a.GetLength(0);
                Console.WriteLine("  " + avgrow);
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 6, 3, 4 }, { 7, 3, 9 }, { 3, 2, 6 } };
            Average.Avrageofrow(arr);
        }
    }
}
    


