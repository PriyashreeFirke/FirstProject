using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam2
{
    class Ten
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number");
            int num1 = int.Parse(Console.ReadLine());

            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if ((num % 1 == 0) && (num1 %1==0))
                {
                    isPrime = false;
                }
            }
            if (isPrime == true)
            {


                Console.WriteLine(" not prime");
            }
            else
            {
                Console.WriteLine(" prime");
            }
           
            if (num - num1 == 2 || num1- num==2)
            {
                Console.WriteLine("twin prime");
            }
            else
            {
                Console.WriteLine("not twin prime");
            }
        }
            
            }

               
        }
    

