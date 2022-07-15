using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam
{
    class leap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
           

        }
    }
}
