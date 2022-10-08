using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Online
{
    class Staticdemo2
    {
        int x = 10;
        static int y = 56;

        void show()
        {
            Console.WriteLine(x + " " + y); ;
        }
        static void Mymethod()

        {
            Staticdemo2 S = new Staticdemo2();
            Console.WriteLine(S.x + " " + y);
            int c = S.x + y;
        }
        static void Main(string[] args)
        {
            Staticdemo2 d = new Staticdemo2();
            d.show();
            Staticdemo2.Mymethod();
            //Console.WriteLine(x);
        }
    }
}
