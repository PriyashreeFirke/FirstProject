using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Reverseprint
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 33, 22, 55 };
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
