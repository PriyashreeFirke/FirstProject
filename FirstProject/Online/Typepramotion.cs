using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Online
{
    class Typepramotion
    {
        void Addition(int x, float y)
        {
            Console.WriteLine(x+y);
        }
        static void Main(string[] args)
        {
            Typepramotion p = new Typepramotion();
            //p.Addition(4,6.7);
            p.Addition(7, 51);
        }
    }
}
