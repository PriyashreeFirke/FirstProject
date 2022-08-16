using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Abstraction
{
    interface Ifactorable
    {
        public int factor(int n);
    }
    class Factor:Ifactorable
    {
        public int factor(int n)
        {
            int sum = 0;
            for (int i=1;i<=n;i++)
            {
                if (n%i==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }



    class Interfavce1
    {
        static void Main(string[] args)
        {
            Ifactorable f = new Factor();
            int ans = f.factor(5);
            Console.WriteLine("sum of factor:"+ans);
        }
    }
}
