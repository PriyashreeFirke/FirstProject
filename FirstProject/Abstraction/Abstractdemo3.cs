using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Abstraction
{

    abstract class vechical
    {
        public abstract void Run();
    }
    abstract class car : vechical
    { 
    }
    class BMW : car
    {
        public override void Run()
        {
            Console.WriteLine("BMW is running");
        }
    }


    class Abstractdemo3
    {
    }
}
