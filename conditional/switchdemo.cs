using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class switchdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char");
            char ch = char.Parse(Console.ReadLine());
            /*switch(expression)
            {
                case
                break;
                    case
                    break;
                    default
                    break;*/
            //char ch='t';
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonent");
                    break;

            }


        }
    }
}
