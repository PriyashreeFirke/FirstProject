using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Tuuupledemo
    {
        static(int,int,string) Calculate(int a,int b,string s)
        {
            int sum = a + b;
            int prod = a * b;
            return (sum,prod,"hello");
        }
        static void Main(string[] args)
        {
            var (Add, mul,msg) = Calculate(8, 3,"hello");
            Console.WriteLine(Add);
            Console.WriteLine(mul);
        }
    }
}
