using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.pratisenew
{
    class practise3
    {
         int m1()
        {
            
            return 2;
        }

         float m1(float f)
        {
            
            return 1;
        }
        static void Main(string[] args)
        {
            practise3 p = new practise3();
            
            Console.WriteLine(p.m1());
            Console.WriteLine(p.m1(2f));
        }
    }
}
