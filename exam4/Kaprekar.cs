using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam4
{
    class Kaprekar
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter an Positive Integer Number:: ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            if (IsKaprekar(number))
                Console.WriteLine(number + " is a kaprekar number");
            else
                Console.WriteLine(number + " is not a kaprekar number");

        }

        public static bool IsKaprekar(int number)
        {
           
            int n = number;
            int count = 0;

            while (n >0)
            {
                count++;
                n = n / 10;
            }
            number = n;
            int sq = number * number;
            int power = 1;


            for (int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            int q = sq / power;
            int r = sq % power;
            int sum = q + r;
            Console.WriteLine("sum="+sum);


            if (sum == number)
            {
                return true;
            }
            else
            {
                return false;
            }

            }
            
        }

    }

    
    

