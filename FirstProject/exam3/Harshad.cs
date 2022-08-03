using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam3
{
    class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int rem =0;
            int n = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            
            if (n % sum == 0)
            {
                Console.WriteLine("harshad number");
            }
            else
            {
                Console.WriteLine("not harshad number");
            }
            
    

        }
    }
}
         