using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam2
{
    class pattern
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int i, j, k;
            for (i = 1; i <= 4; i++)
            {
                for (j = i; j <= 4; j++)
                {
                    Console.Write(" ");

                }
                for (k = 1; k <= i + temp; k++)
                {

                    Console.Write(i);

                }
                temp++;

                Console.WriteLine();
            }
        }
    }
}


