using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Inheritance
{
    class Mobile
    {
        internal string memory_size = "64Gb";
    }
    class Apple : Mobile
    {
        public void Show()
        {
            Console.WriteLine(memory_size);
        }
    }


    class SingleDemo
    {

        static void Main(string[] args)
        {
            Apple iphone = new Apple();
            iphone.Show();
            Console.WriteLine(iphone.memory_size);
        }
    }
}
