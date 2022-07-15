using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam
{
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("number is divisible ");

            }
            else
            {
                Console.WriteLine("number is not divisible");
            }
        }
    }
}
