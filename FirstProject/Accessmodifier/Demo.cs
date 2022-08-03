using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Accessmodifier
{
    class Demo
    {
        private int x = 10;
        internal int y = 30;
        protected int z = 45;
        public string name = "ria";

        static void Main(string[] args)
        {
            Demo d = new Demo();
            Console.WriteLine(d.x);
            Console.WriteLine(d.y);
            Console.WriteLine(d.z);
            Console.WriteLine(d.name);
        }
    }
}
