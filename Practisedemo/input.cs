using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Practisedemo
{ //program to input no and check greter than 5
    class input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            if (num > 5)
            {
                Console.WriteLine("number is greter");

            }
            else
            {
                Console.WriteLine("number is not greater");
            }
        }
    }
}
