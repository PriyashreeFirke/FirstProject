using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
    class mathpower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base");
            int baseno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter exponent");
            int exp = int.Parse(Console.ReadLine());
            int power = 1;
            for (int i = 1; i <= exp; i++)
            {
                power = power * baseno;

            }
            Console.WriteLine(power);

        }
    }
}
