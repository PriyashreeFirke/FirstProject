using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class Twinprime
    {
        public static bool TwinPrime(int num,int num1)
        {
            bool isprime = true;
            for(int i=2;i<num;i++)
            {
                if(num%1==0 && num1%1==0)
                {
                    isprime = false;

                }
            }
            if(isprime==true)
            {
                Console.WriteLine("not prime");
            }
            else
            {
                Console.WriteLine("prime");
            }
            if(num-num1==2 || num1-num==2)
            {
                Console.WriteLine("twin prime");
            }
            else
            {
                Console.WriteLine("not twin prime");
            }
            return false;
        }
        static void Main(string[] args)
        {
            int num = 3;
            int num1 = 5;
            TwinPrime(num, num1);
        }
    }
}
