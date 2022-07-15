using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Ternaryoperator
{
    class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());

            //string ans = Num % 2 == 0 ? "num is even" : "num is odd";
            string ans = Num > 0 ? "number is positive" : Num<0 ? " number is negative" : "zero";
            
            Console.WriteLine(ans);
            
        }

}}
