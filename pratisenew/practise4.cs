using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.pratisenew
{

    class own
    {
        public virtual void m1()
        {
            Console.WriteLine("method");
        }
    }
    class practise4 : own
    {
        public override sealed void m1()
        {
            Console.WriteLine("sealed method");
        }

        static void Main(string[] args)
        {
            practise4 a = new practise4();
            a.m1();
        }
    }
}
