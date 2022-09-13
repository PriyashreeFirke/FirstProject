using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Tuuple
    {
        static Tuple<int,int> calculate (int a,int b)
        {
            int sum = a + b;
            int prod = a * b;
            return Tuple.Create(prod, sum);
        }
        static void Main(string[] args)
        {
            Tuple<int, int> t = calculate(12, 3);
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);
        }
    }
}
