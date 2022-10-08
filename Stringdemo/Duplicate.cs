using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Duplicate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");

            string str = Console.ReadLine();

            string result = "";
            result=result+ str[0]; 

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] != str[i])
                    result =result+ str[i];
            }

            Console.WriteLine(result);
        }
    }
}
