using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Ternaryoperator
{
    class Demo
    {
        static void Main(string[] args)
        {
            int n1 = 4;
            int n2 = 7;
            if (n1 > n2)
            {
                Console.WriteLine("n1is greter");

            }
            else 
            {
                Console.WriteLine("n2 is greter");

            }
            //ternary opertor ?:
            // condition ? true part: false part

            // int result = n1>n2 ? n1: n2;
            // Console.WriteLine("Result  " +result);


            string ans = n1 > n2 ? "n1 is greter" : "n2 is greter";
            Console.WriteLine(ans);
        }
    }
}
