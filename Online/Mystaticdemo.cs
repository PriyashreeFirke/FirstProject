using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Online
{
    class Mystaticdemo
    {
        static int x = 10;

        static Mystaticdemo()
        {
            Console.WriteLine("my static");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(x);
        }
    }
}
