using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Patternarray
{
    class PatternN
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (j == 0 || j == a.GetLength(1)||i==j)
                    {
                        Console.Write(a[i,j]+"");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
