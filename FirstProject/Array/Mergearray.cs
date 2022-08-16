using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Mergearray
    {
        public static void Joinarray(int[] a, int[] b, int[] merg)
        {
            int m = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool ispresent = false;
                for (int k = m - 1; k >= 0; k--)
                {
                    if (merg[k] == a[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    merg[m] = a[i];
                    m++;
                }
            }
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine(string.Join(" ", b));
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(merg[i] + "");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 4, 5, 8 };
            int[] b = { 7, 8, 4, 9, 2 };
            int[] c = new int[a.Length + b.Length];
            Joinarray(a, b, c);
        }   
    }
}
