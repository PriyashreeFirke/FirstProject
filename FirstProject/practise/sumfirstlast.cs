using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class sumfirstlast
    {
        static void Main(string[] args)
        {
            int ldigit;
            int fdigit;
            int sum = 0;
            Console.WriteLine("enter number");
            int n1 = int.Parse(Console.ReadLine());

            ldigit = n1 % 10;
            fdigit = n1;
            while(n1 >=10)
            {
                n1 = n1 / 10;
            }
            fdigit = n1;
            sum = fdigit + ldigit;
            Console.WriteLine(sum);
        }
    }
}
