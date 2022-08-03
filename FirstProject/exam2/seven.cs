using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam2
{
    class seven
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5-i; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >0; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
