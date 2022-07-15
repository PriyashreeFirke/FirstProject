using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class This
    {
        int y = 20;
        string number;
         string name;// instance variable
        public void  input(int y)// methods
        {
            this.y = y;// 1use
            Console.WriteLine("new method");
            this.show();// 2use

        }
        public This()
        {
            Console.WriteLine(" default");
        }
        public This(string number, string name):this()//3use
        {
            this.number= number;
            this.name = name;
        }

        public void show()
        {
            Console.WriteLine("y="+y);

            Console.WriteLine(number+""+name);
        }
        
        static void Main(string[] args)
        {
            This t = new This( "101","hii");// object create
            t.input(450);
            t.show();
        }
    }
}
