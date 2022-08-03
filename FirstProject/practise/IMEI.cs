using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class IMEI
    {
        static void Main(string[] args)
        {
          
            int sum = 0;
            int r;
            Console.WriteLine("Enter 15 digit number");
            int n= int.Parse(Console.ReadLine());
            while (n > 0)
            {
                
                
                r = n % 10;
                sum = sum + (int)r;
                n = n / 10;
            }
            Console.WriteLine(sum);
            if (sum % 10 == 0)
            {
                Console.WriteLine("Correct IMEI");
            }
            else
            {
                Console.WriteLine("Invalid IMEI");
            }
        }
    }
}
