using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Abstraction
{
    abstract class mathoperation
    {
        public int a = 67;

    }
    interface IAddable
    {
        static int b = 20;
    }
    class Addition : mathoperation
    {
        public int add()
        {
            return a + IAddable.b;
        }
    }


    class Interface
    {
        static void Main(string[] args)
        {
            Addition m = new Addition();
            Console.WriteLine("Adssddition:"+m.add());
        }
        
    }
}
