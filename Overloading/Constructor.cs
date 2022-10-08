using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Overloading
{
    class Constructor
    {
        int price;
        string name;
        string memory;

        public Constructor()
        {
            Console.WriteLine("i am default");
        }
        public Constructor(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }
        public Constructor(int price, string memory)
        {
            this.price = price;
            this.memory = memory;
            Console.WriteLine(price);
            Console.WriteLine( memory);
        }
    }
        class Constructoroverload
        {
            static void Main(string[] args)
            { 
            Constructor m = new Constructor();
            Constructor m1 = new Constructor("nokia");
            Constructor m2 = new Constructor(300000, "32GB");
            
               
    
        }

    }
}
