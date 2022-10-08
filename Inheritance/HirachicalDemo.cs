using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Inheritance
{
    class vechile
    {
        protected int wheel = 4;
    }
    class car : vechile
    {
        internal string cname = "BMW";

        public void showcar()
        {
            Console.WriteLine(cname+" "+wheel);
        }
    }
    class Truck : vechile
    {
        public void showtruck()
        {
            wheel = 8;
            Console.WriteLine("Truckwheel="+ wheel);
        }
        
    }
    class HirachicalDemo
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.showcar();
            Truck t = new Truck();
            t.showtruck();
        }
        
    }
}
