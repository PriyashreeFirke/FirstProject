using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class Checkvowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char");
            char ch = Convert.ToChar(Console.ReadLine());
            /*if (ch == 'a' || ch == 'A')
            {


                Console.WriteLine("vowel");
            }
            else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine("vowel");

            }
            else if (ch == 'o' || ch == 'O')
            {
                Console.WriteLine("vowel");


            }
            else if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine("vowel");

            }*/
            if (ch == 'a' || ch == 'A' || ch == 'e' || ch =='E' ||ch=='I'|| ch == 'i' ||ch=='O' || ch == 'o' ||ch=='U' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }

        }
    }
}
