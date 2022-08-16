using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Base
{
    class Laptop
    {
        public Laptop() //or public laptop(int x)
        {
            Console.WriteLine("laptop");
        }
    }
    class Dell : Laptop
    {
        public Dell():base()//or base(64)
        {
            Console.WriteLine("dell....");
        }
    }
    class Base3
    {
        static void Main(string[] args)
        {
            Dell d = new Dell();
        }
    }
}
