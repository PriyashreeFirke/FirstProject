using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Base
{
    class number
    {
        int y;
        int z;
        public void input(int y)
        {
            z = 6;
            this.y = y;// 1use
            Console.WriteLine("new method");
           
        }
        class Digit : number
        {
            public void show()
            {
                Console.WriteLine("y=" + y+" "+base.z);//use1
                this.input(3);//use2
            }
        }
        class positivenumber : Digit
        {
            public void show()
            {
                Console.WriteLine("positive number");
                base.show();//use2
            }
        }
        class even
        {
            public even()
            {
                Console.WriteLine(  "even number");
            }
        }
        class prime:even
        {
            public prime() : base()
            {
                Console.WriteLine("prime...");

            }
        }
        class ThisBasekeyword
        {
            public  ThisBasekeyword()
            {
                Console.WriteLine("default");
            }
            public ThisBasekeyword(int x):this()//use3
        {
                x = 5;
                Console.WriteLine("x" + x);
            }
            class Display
            {
                static void Main(string[] args)
                {
                    Digit d =new Digit();
                }
            }
        }
    }
}
        
