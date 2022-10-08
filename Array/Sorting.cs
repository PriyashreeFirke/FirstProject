using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Sorting
    {
        public static int[] Mysort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j =  1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                    }

                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] arr = { 13, 423, 6, 7, 9, 5 };
            Console.WriteLine(string.Join(" ", arr));
            int[] sorted = Sortarray.Mysort(arr);
            Console.WriteLine("........");
            Console.WriteLine(string.Join(" ", sorted));
        }

    }
}

