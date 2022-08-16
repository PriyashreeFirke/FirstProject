using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Abstraction
{
    interface Imoveable
    {
        //int x=45;//error not allow in non satic member
        void move();
       /* static void show()
        {
            Console.WriteLine("show method");
        }
        public int Add()
        {
            return 2 + 3;
        }*/
    }
    class Bus:Imoveable
    {
        public void move()
        {
            Console.WriteLine("bus is moving");
            
        }
       
             
    }

    class Interfacedemo
    {
        static void Main(string[] args)
        {
            /*Bus b = new Bus();
            b.move();*/

            Imoveable m = new Bus();
            m.move();
           /* Console.WriteLine(m.Add());
            Imoveable.show();*/
        }
    }
}
