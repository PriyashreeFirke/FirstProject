using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam
{
    class maximum
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is maximim");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is maximum");

            }
            else
            {
                Console.WriteLine("num3 is maximum");
            }
        }
    }
}
