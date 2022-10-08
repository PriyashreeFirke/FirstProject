using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject._2darray
{
    class Sparsematrix
    {
        static void Main(string[] args)
        {

            int count = 0;
            int count1 = 0;
            int[,] a = new int[3, 3];
            Console.WriteLine("enter element");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

                    for (int i = 0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]==0)
                    {
                        count++;
                    }
                    else
                    {
                        count1++;
                    }
                }
            }
            if( count>count1)
            {
                Console.WriteLine("sparse matrix");
            }
            else
            {
                Console.WriteLine("not sparse");
            }
    } }
}
