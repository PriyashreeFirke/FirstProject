using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Abstraction
{
    abstract class Animal
    {
        public abstract void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("dog eating....");
        }
    }


    class Abstractdemo
    {
        static void Main(string[] args)
        {


            Dog d = new Dog();
            d.Eat();
        }
    }
}
