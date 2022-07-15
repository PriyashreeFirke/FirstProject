using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class pattern
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            { 
            
            for (int j = 1; j <= i; j++)
            {
            Console.Write("*");
            }
            Console.WriteLine();
             }
            
            
            for (int i = 1; i <= 4; i++)
            {
            for (int j = 1; j <= i; j++)
            {
             Console.Write(i);
            }
            Console.WriteLine();

            }
            
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();

                }
                for (int i = 4; i >= 1; i--)
                {
                    for (int j = 1; j <= 4 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (char i = 'D'; i >= 'A'; i--)
                {
                    for (char j = 'A'; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();

                }
                for (int i = 4; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();

                }
                for (int i = 1; i <= 4; i++)
                {

                    for (int j = 4; j >= i; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
  
