using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int copy = n;
            int sum = 0;
            while (n > 0)
            {
                int r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;

            }
            if (sum == copy)
                Console.WriteLine($"{copy} is palindrom");

            else
                Console.WriteLine($"{copy} is not palindrom");
            
        }
    }
}
