using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.assignment
{
    class Nine
    {
        static void Main(string[] args)
        {
            int n, product = 1, k;
            Console.WriteLine("write number");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                k = n % 10;
                n = n / 10;
                product = product * k;
            }
            Console.WriteLine("product of digit"+ product);
        }
    }
}
