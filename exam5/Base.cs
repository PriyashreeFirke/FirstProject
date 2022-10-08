using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam5
{
     
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("eating bread...");
        }

    }
    public class TestBase
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.eat();
        }
    }
}

