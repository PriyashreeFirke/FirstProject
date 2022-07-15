using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class swapping
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 22;
            b = 77;
            Console.WriteLine("before swapping a=" +a +"b= "+b);

            c = a;
            a = b;
            b = c;
            Console.WriteLine("after swappin a=" +a + "b="+b);
        }
    }
}
