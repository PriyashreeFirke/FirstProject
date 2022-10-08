using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Basic
{
    class expression
    {
        static void Main(string[] arg)
        {
            int a = 2;
            int b = 2;
            int x = b++ + ++a - --a;
            Console.WriteLine(x + "" + a + "" + b);
            x = --b - ++a + b++;
            Console.WriteLine(x + "" + a + "" + b);
            x = a-- + b - ++a - --b;
            Console.WriteLine(x + "" + a + "" + b);
        }
    }
}
