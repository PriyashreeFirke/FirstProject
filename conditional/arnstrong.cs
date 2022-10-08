using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class arnstrong
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int temp;
            int a;
            
            Console.WriteLine("enter number");
            int num1= int.Parse(Console.ReadLine());
            temp = num1;
            while (num1 != 0)
            {
                a = num1 % 10;
                sum = sum + (a * a * a);
                num1 = num1 / 10;
                    }
            if (sum == temp)
            {
                Console.WriteLine("number is arnstrong");
            }
            else 
            {
                Console.WriteLine("number is not arnstrong");
            }
            }
            }
        }
    

