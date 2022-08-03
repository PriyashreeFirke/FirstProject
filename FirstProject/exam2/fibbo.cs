using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam2
{
    class fibbo
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c ;
            Console.WriteLine("enter the term :" );
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            { 
                if (i <= 1)
                    c = i;
                else
                {

                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine(c+ " ");
            }
            Console.ReadKey();
        }
        

     
      
                                     
    }
}
