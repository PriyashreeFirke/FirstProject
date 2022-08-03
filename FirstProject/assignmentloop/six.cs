using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.assignment
{
    class six
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i += 2)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
