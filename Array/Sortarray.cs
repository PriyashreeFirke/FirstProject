using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Sortarray
    {
        
        public static int[] Mysort(int[]a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < (a.Length) / 2; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                    }
                }
                for (int k = (a.Length) / 2 + 1; k < a.Length; k++)
                {
                    if (a[i] > a[k])
                    {
                        int temp = a[i];
                        a[i] = a[k];
                        a[k] = temp;

                    }
                }
            }
                   
            return a;
        }
        static void Main(string[] args)
        {
            int[] a = { 13, 4,23, 6, 7, 9, 5 };
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("........");
            Sortarray.Mysort(a);
            
            
        }
            
    }
}
