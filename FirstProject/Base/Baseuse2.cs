using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Base
{
    class Bird
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
    class Sparrow : Bird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying....");
            base.Fly();
        }
    }
    class Baseuse2
    {
        static void Main(string[] args)
        {
            Sparrow p = new Sparrow();
            p.Fly();
        }
    }
}
