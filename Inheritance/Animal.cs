using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Inheritance
{
    class Animal
    {
        internal int legs = 4;
    }
    class Dog:Animal
    {
        internal string color = "white";
        public void show()
        {
            Console.WriteLine(color+" "+legs);
        }
    }
    class rabbit : Animal
    {
        public void show()
        {
            Console.WriteLine(legs);
        }
    }
    class info
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.show();
            rabbit r = new rabbit();
            r.show();

        }
    }
            
        }
    

