using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.assignment
{
    class four
    {
        static void Main(string[] args)
        {
            long num1, num2, hcf, lcm;
            

            Console.Write(" Input the first number : ");
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.Write(" Input the second number : ");
            num2 = Convert.ToInt64(Console.ReadLine());

            hcf = gcd(num1, num2);
            lcm = (num1 * num2) / hcf;

            Console.WriteLine("\n The GCD of {0} and {1} = {2} ", num1, num2, hcf);
            Console.WriteLine(" The LCM of {0} and {1} = {2}\n", num1, num2, lcm);
             long gcd(long n1, long n2)
            {
                if (n2 == 0)
                {
                    return n1;
                }
                else
                {
                    return gcd(n2, n1 % n2);
                }
            }
        }

    }
    }

