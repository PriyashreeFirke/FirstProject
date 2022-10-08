using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.pratisenew
{

    abstract class fruit
    {
        int x = 20;
        public abstract void M1();

        public fruit(string name)
        {
            Console.WriteLine(name);
        }

        public void m2()
        {
            Console.WriteLine("sweet");
        }
        
    }
    class Apple:fruit
    {
        public Apple():base ("orange")
        {

        }
            public override void M1()
        {
            Console.WriteLine("eat");
        }
    }
    class practise1
    {
        static void Main(string[] args)
        {
            Apple a = new Apple();
            a.M1();
            a.m2();

        }
    }
}
