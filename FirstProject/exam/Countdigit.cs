using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam
{
    class Countdigit
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            
            
            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                count++ ;
            }
            Console.WriteLine(count);
        }
    }
}
