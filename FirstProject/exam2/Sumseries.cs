using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam2
{
    class Sumseries
    {
        static void Main(string[] args)
        {
			int num, i, j, fact, sum = 0;

            Console.WriteLine("Enter the last number of series:");
			 num = int.Parse(Console.ReadLine());
			for (i = 1; i<=num; i++)
			{
				fact = 1;
				if (i != num)
				{
					Console.WriteLine(i);
				}
				else
				{
					Console.WriteLine("");
				}
				for (j = 1; j <= i; j++)
					fact = fact * j;
				sum = sum + fact;
			}
            Console.WriteLine(sum);
			
		}
    }
}
