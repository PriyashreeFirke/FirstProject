using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam7
{
    class Sort
    {
        public static int[] Mysort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 1; j < a.Length; j++)
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
            int[] arr = { 1, 2, 3, 4 , 5, 6, 7, 8 } ;
            Console.WriteLine(string.Join(" ", arr));
            int[] sorted = Sort.Mysort(arr);
            Console.WriteLine("........");
            Console.WriteLine(string.Join(" ", sorted));
        }

    }
}

