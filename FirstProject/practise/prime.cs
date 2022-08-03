using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class Prime
    {
        public void Display()
        {

            for (int i = 1; i <= 20; i++)
            {
                bool isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(i); 
                }

               
            }
        }
             static void Main(string[] args)
            {
                Prime d = new Prime();
                d.Display();
            }
        }
    }

