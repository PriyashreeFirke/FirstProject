using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Practisedemo
{
    class second
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else 
            {
                Console.WriteLine("number is odd");
            }
        }
    }
}
