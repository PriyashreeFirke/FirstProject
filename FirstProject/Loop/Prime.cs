using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ente number");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % 1 == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime == true)
            {


                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
