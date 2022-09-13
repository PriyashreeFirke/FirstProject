using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class Coprime
    {
        static void Main(string[] args)
        {
            int r=0;
            Console.WriteLine("enter  1st number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int n2 = int.Parse(Console.ReadLine());
            for(int i=1;i<n1;i++)
            {
                if(n1%1==0 && n2%1==0)
                {
                    r = i;
                }
            }
            if(r==1)
            {
                Console.WriteLine("coprime");
            }
            else
            {
                Console.WriteLine("not");
            }

        }
    }
}
