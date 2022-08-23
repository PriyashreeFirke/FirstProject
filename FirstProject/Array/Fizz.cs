using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Fizz
    {
        static void Main(string[] args)
        {
           int count = 0;
            for(int i=1;i<=50;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZ BUZZ");
                    count++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("BUZZ");
                    count++;
                }
                else if (i % 5 == 0) 
                {
                  Console.WriteLine("FIZZ");
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                }
                    
                
            }
        }
    }
}
