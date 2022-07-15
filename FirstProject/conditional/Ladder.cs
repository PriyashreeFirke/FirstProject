using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class Ladder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 0)
            {
                Console.WriteLine("number is zero" + num1);

            }
            else if (num1 > 0)
            {
                Console.WriteLine("number is positive" + num1);

            }
            else 
            {
                Console.WriteLine("number is negative" + num1);
            }
        }
    }
}
