using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Accessmodifier
{
    class Demo1 : Demo
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            //Console.WriteLine(d.x);// error because private modifier
            Console.WriteLine(d.y);
            Console.WriteLine(d.name);
           


            Demo1 r = new Demo1();
            Console.WriteLine(r.z);
            Console.WriteLine( r.name);
        }
    }
}
