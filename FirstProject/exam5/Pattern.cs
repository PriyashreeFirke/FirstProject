using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam5
{
    class Pattern
    {
        static void Main(string[] args)
        {

            int i, j, k, l = 1;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write(" ");

                }
                for (k = 1; k <= l; k++)
                {
                    Console.Write(k);
                }
                l = l + 2;
                Console.Write("\n");
            }
            Console.ReadLine();
        }

        }
    }

