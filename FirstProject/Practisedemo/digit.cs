using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Practisedemo
{
    class digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 9)
            {
                Console.WriteLine("n8mber is one digit");
            }
            else if (num >= 10 && num <= 99)
            {
                Console.WriteLine("number is two digit");
            }
            else
            {
                Console.WriteLine("number is three digit");
            }
        }
    }
}
