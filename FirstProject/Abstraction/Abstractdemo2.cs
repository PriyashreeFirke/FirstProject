using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Abstraction
{
    abstract class Animal1
    {
        internal int x = 10;
        internal static int y = 20;
        internal const int z = 78;
        public abstract void Eat();//abstract method
        public Animal1(int legs)//constructor
        {
            Console.WriteLine("Animal"+legs);
        }
        public void Run()//non abstract method
        {
            Console.WriteLine("Animal is running");
        }
    }
    class Dog1: Animal1
    {
        public Dog1() : base(4)
        { 
        }
        public override void Eat()
        {
            Console.WriteLine("Dog eating");
        }
    }

    class Abstractdemo2
    {
        static void Main(string[] args)
        {
            Dog1 b = new Dog1();
            b.Eat();
            b.Run();
        }

    }
}
