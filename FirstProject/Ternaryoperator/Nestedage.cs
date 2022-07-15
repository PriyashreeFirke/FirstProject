using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Ternaryoperator
{
    class Nestedage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter wt");
            int wt = int.Parse(Console.ReadLine());
            if (age > 18 && wt > 50)
            {
                Console.WriteLine("person is valid");
            }
            else
            {
                Console.WriteLine("person is not valid");
            }

           /* if (age > 18)
            {
                if (wt > 50)
                {
                    Console.WriteLine("person is valid for blood dontion");
                }
                else
                {
                    Console.WriteLine("person is not valid");



                }
            }
            else
            {
                Console.WriteLine("person is not valid try again.....");
            }*/
        }
    }
}
