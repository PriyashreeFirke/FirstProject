using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam4
{
    class frequency
    {
        int FrequencyDigit(long n1, int f)
        {


            int c = 0;
            while (n1 > 0)
            {
                if (n1 % 10 == f)
                    c++;

                n1 = n1 / 10;
            }
            return c;

        }
        static void Main(string[] args)
        {
            frequency m = new frequency();
           
            Console.WriteLine("Enter mobile number");
            long n1 = long.Parse(Console.ReadLine());

            Console.WriteLine("find frequency of");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine(m.FrequencyDigit(n1, f));
               
        }
    }
    }

            