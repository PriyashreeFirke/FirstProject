using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Ternaryoperator
{
    class Friend
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your friend age");
            int age2 = int.Parse(Console.ReadLine());
            if (age2 < age)
            {
                Console.WriteLine("Hi");

            }
            else if (age < age2)
            {
                Console.WriteLine("Good morning");
            }
            else
            {
                Console.WriteLine("How are YOU?");
            }

        }
    }
}
