using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject._2darray
{
    class Sumofcol
    {
        public static void SUMOFCOL(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[j, i];
                }
                Console.Write("sum="+sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,]arr= { { 6, 3, 4 }, { 7, 3, 9 }, { 3, 2, 6 } };
            Sumofcol.SUMOFCOL(arr);
        }

    }
}
