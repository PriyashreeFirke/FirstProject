using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class Recursionfact
    {
        public static int Fact(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                return n * Fact(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int result = Fact(3);
        }
    }
}
