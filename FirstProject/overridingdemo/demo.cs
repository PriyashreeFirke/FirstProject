using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.overridingdemo
{
    class fruit
    {
        public virtual void Test()
        {
            Console.WriteLine("Test is sweet");
        }
    }
    class Mango : fruit
    {
        public override void Test()
        {
            Console.WriteLine("Mango is sweet");
            base.Test();

        }
    }
    class Banana : fruit
    {
        public override void Test()
        {
            Console.WriteLine("Banana is sweet");
        }

    }
        


    class demo
    {
        static void Main(string[] args)
        {
            fruit f = new Mango();
            f.Test();

            fruit f2 = new Banana();
            f.Test();
        }
    }
}
