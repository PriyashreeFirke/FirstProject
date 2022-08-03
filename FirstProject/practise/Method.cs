using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class Method
    {
        bool Prime(int n)
        {
            bool isprime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
         
        
                return isprime;
            }
            static void Main(string[] args)
            {
                Method m = new Method();
            bool b = m.Prime(15);
            if (b == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
                
           

            }
            
            
            
            
        }
    }

