using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.breakcontinue
{
    class Digitsum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            Console.WriteLine("sum=" +sum);
        }
    }
}
