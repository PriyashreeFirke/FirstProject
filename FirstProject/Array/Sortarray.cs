using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Sortarray
    {
        
        public static int[] Mysort(int[]a)
        {
            int n = a.Length;
            for(int i=0;i< a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                     }
                    for (int k = 0; k < n / 2; k++)
                    {
                        Console.WriteLine(a[k] + " ");
                    }
                    for(int m=n-1;m>n/2;m--)
                    {
                        Console.WriteLine(a[m]+" ");
                    }
            
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] a = { 13, 4,23, 6, 7, 9, 5 };
            Console.WriteLine(string.Join(" ",a));
            int[] sorted = Sortarray.Mysort(a);
            Console.WriteLine("........");
            Console.WriteLine(string.Join(" ",sorted));
            
        }
            
    }
}
