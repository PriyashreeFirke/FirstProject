using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Practisedemo
{
    class Teenage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("person is teenage");

            }
            else 
            {
                Console.WriteLine("person is not teenage");
            }
        }
    }
}
