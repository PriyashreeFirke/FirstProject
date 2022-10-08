using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Evensum
    {
        public int Even(int[] a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int [] arr = new int[5];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr [i] = int.Parse(Console.ReadLine());
            }
            Evensum e = new Evensum();
            int sum = e.Even(arr);
            Console.WriteLine("sum of even element ="+sum);

        }
    }
}
