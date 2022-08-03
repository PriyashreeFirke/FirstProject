using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class Happy
    {
        static void Main(string[] args)
        {
            int rem = 0; 
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int n = num;
            while (num > 0)
            {
                rem = num % 10;
                
                num = num / 10;

                
            }
            if ( (n/10) % 2 == 0)
            {
                Console.WriteLine("not happy");
            }
            else
            {
                Console.WriteLine(" happy");
            }
        }
    }
}
