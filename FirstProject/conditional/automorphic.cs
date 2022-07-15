using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int sq = n * n;
            int c = 1;
            while (n > 0)
            {
                if (n % 10 != sq % 10)
                {
                    c = 0;
                }
                n = n / 10;
                sq = sq / 10;

            }
            {
                if (c == 1)
                {
                    Console.WriteLine("automorphic");

                }
                else
                {
                    Console.WriteLine("not automorphic");
                }

            }
        }




    }
}   
    
