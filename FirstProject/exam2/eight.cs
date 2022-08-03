using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam2
{
    class eight
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
}