using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class ReverseArray
    {
        public static int[] Reverse(int[]a)
        {
            int j = a.Length - 1;
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter array elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ",arr));
            int[]r= ReverseArray.Reverse(arr);
            Console.WriteLine(".............");
            Console.WriteLine(string.Join(" ",arr));

        }
    }
}
