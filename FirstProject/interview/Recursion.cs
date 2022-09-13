using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class Recursion
    {
        static public void m1(int x)
        {
            Console.WriteLine("in m1");
            if(x<=3)
            {
                m1(x + 1);

            }
            Console.WriteLine("m1 ends");
        }
        static void Main(string[] args)
        {
            m1(1);
        }
    }
}
