using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.pratisenew
{
    class Class6
    {
        private int x = 10;
        public int y = 20;
        internal int z = 5;
        protected int v = 70;

        static void Main(string[] args)
        {
            Class6 c = new Class6();
            Console.WriteLine(c.x);
            Console.WriteLine(c.y);
            Console.WriteLine(c.z);
            Console.WriteLine(c.v);
        }
    }
}
