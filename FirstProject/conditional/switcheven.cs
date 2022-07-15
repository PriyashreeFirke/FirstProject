using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class switcheven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter 2nd nuber");
            //int num2 = int.Parse(Console.ReadLine());
            switch (num1 % 2)
            {
                case 0:
                    Console.WriteLine("number is even");
                    break;
                default:
                    Console.WriteLine("number is odd");
                    break;
            }
        }
    }
}
