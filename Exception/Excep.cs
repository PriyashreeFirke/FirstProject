using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Exception
{
    class Excep
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter 2number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("addition=" + (a+b));
            }
            catch(FormatException e)
            {
                Console.WriteLine("pleasr enter valid number");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("number too big");
            }
            
        }
    }
}
