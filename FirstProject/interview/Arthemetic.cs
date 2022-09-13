using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class Arthemetic
    {
        public static void Arthemetic_progression(int t2,int t3,int n)
        {
            int diff = t3 - t2;
            int t4 = t3;
            for(int i=4;i<=n;i++)
            {
                t4 = t4 + diff;

            }
            Console.WriteLine(t4);
        }


        static void Main(string[] args)
        {
            Arthemetic_progression(3, 7, 8);
        }
    }
}
