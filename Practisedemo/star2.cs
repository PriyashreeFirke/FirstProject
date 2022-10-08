using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Practisedemo
{
    class Star2
    {
        static void Main(string[] args)
        {

            int n= 4;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == j || i == 4)
                    {
                        Console.WriteLine("*");
                    }
                    else
                        Console.WriteLine("");
                }
                Console.WriteLine();
            }
        }
        
    }
}
