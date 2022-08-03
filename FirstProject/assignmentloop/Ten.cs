using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.assignment
{
    class Ten
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0}X{1}={2}\n", num, i, num * i);
            }
            Console.ReadLine();

        }
    }
}
