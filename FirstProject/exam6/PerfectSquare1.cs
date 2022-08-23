using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    class PerfectSquare1
    {
        static void Main(string[] args)
        {

            int count = 0;
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("enter array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                int sqr= a[i] * a[i];
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == sqr)
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine(" " + count);

        }
    }
}
