using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam4
{
    class Exponent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base");
            int base_number = int.Parse(Console.ReadLine());
            Console.WriteLine("enter exponent");
            int expo = int.Parse(Console.ReadLine());

            int power = 1;
            for (int i = 1; i <= expo; i++)
            {
                power = power * base_number;
            }
            Console.WriteLine(power);
        }
    }
}
