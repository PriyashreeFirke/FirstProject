using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Patternarray
{
    class Pattern
    {
        public static void OuterElement(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == a.GetLength(0)||j==a.GetLength(1))
                    {
                        Console.Write(a[i,j]+"");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            Console.WriteLine("enter thearray");
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("/////////////");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();

            }

        }
    }
   
    
}
