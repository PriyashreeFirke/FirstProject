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
           
            int square = 0;
            int n = 0;
            int countDigits = 0;
            
            int sum = 0;

           
            square = number * number;

            
            n = square;
            while (n!= 0)
            {
                countDigits++;
                n = n / 10; 
            }

            
            for (int i = countDigits - 1; i > 0; i--)
            {
               
                
               
                if (sum == number)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
    
    

