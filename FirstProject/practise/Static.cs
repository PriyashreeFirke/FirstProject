using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class Static
    {
        int x = 6;
        int y = 8;
       

        static void Calculate(int x,int y)
        {
            Console.WriteLine("Addition =" + x+y); 
        }
        static void Calculate(int x, float y)
        {
            Console.WriteLine("Subtraction =" + (x-y));

        }
        static void Calculate(float x, int y)
        {
            Console.WriteLine("division ="  + x/y);
        }

        static void Main(string[] args)
        {
            Static.Calculate(4, 6);
            Static.Calculate(6, 8f);
            Static.Calculate(4f, 2);
            
        }
    }
}
