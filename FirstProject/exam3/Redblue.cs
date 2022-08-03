using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam3
{
    class Redblue
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("red");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("blue");
                }
                 else
                {
                    Console.WriteLine(  i);
                }

            }
        }
    }
}
