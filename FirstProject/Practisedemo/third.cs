using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Practisedemo
{
    class third
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater"); 
            }
            else 
            {
                Console.WriteLine("num2 is greater");
            }
        }
    }
}
