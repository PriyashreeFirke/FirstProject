using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Online
{
    class Staticdemo
    {
        static int x=0;

        Staticdemo()
        {
            x++;
            Console.WriteLine(x);
        }
        void display()
        {
            Console.WriteLine(x);
        }
        static int Addition()
        {
            return 2 + 5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(x);
            Staticdemo d = new Staticdemo();
            Staticdemo d1 = new Staticdemo();
            Staticdemo d2 = new Staticdemo();
            // Console.WriteLine(d.x); error
            Console.WriteLine(Staticdemo.x);


            int ans = Staticdemo.Addition();
            Console.WriteLine("Addition ="+ans);
        }

    }
}
