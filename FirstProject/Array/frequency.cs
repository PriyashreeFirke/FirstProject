using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class frequency
    {
        static int Frequency(int[]a,
       int n, int x)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (a[i] == x)
                    count++;
            return count;
        }

        
        static public void Main()
        {


            int[] a = { 0, 5, 5, 5, 4 };
            int x = 5;
            int n = a.Length;

            Console.Write(Frequency(a, n, x));
        }
    }
}

