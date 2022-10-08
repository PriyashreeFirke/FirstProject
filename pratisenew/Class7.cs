using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.pratisenew
{
    class Class7:Class6
    {
        static void Main(string[] args)
        {

            Class6 c = new Class6();
            //Console.WriteLine(c.x);//private
            Console.WriteLine(c.y);
            Console.WriteLine(c.z);
           // Console.WriteLine(c.v);protected


            Class7 v = new Class7();
            Console.WriteLine(v.v);
            Console.WriteLine(v.y);
        }


    }
}
