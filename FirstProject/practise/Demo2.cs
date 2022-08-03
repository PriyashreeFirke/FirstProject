using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class Demo2
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int p;
        Console.WriteLine("enter number");
            int num1 = int.Parse(Console.ReadLine());
            while(num1>0)
            {
               p = num1 % 10;
                num1 = num1 / 10;
                if(p % 2==0)
                {
                    sum = sum + p;
                }
            }
            
       
                Console.WriteLine(sum);

            }
    }
}
