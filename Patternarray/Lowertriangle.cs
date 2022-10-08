using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Patternarray
{
    class Lowertriangle
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(i>=j)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                }
                Console.WriteLine();
            }
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.WriteLine(a[i,j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
