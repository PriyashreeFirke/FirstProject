using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Online
{
    class Staticdemo3
    {
        static Staticdemo3()
        {
            Console.WriteLine("HIII");
        }
        Staticdemo3()
        {
            Console.WriteLine("default");
        }
        static void Main(string[] args)
        {
            Staticdemo3 D = new Staticdemo3();
            Staticdemo3 d1 = new Staticdemo3();
        }

    }
}
