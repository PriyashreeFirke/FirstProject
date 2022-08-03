using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam3
{
    class Krishna
    {
        static void Main(string[] args)
        {
            int temp, sum, currentDigit, fact;
            Console.WriteLine("Enter an Integer: ");
            int number = int.Parse(Console.ReadLine());
            temp = number;
            sum = 0;

            while (temp != 0)
            {
                currentDigit = temp % 10;
                fact = 1;

                // finding factorial of the currentDigit
                for (int i = 1; i <= currentDigit; i++)
                {
                    fact *= i;
                }

                sum += fact;
                temp /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine("krishn murty");
            }
            else
            {
                Console.WriteLine("not krishn murthy");
            }

            
        }




    }

    }

