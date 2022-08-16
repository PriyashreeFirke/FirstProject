using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Fizz
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZ BUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if (i % 5 == 0) 
                {
                  Console.WriteLine("FIZZ");
                }
                else
                {
                    Console.WriteLine(1);
                }
                    
                
            }
        }
    }
}
