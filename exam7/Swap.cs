using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam7
{
    class Swap
    {
        public void swap(int[]a)

        {
            int first = a[0];
            
            a[0] =a[a.Length - 1];
            a[a.Length - 1] = first;
            first = a[1];
            a[1] = a[a.Length - 2];
            a[a.Length - 2] = first;
            
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter array elmewnt");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Swap s=new Swap();
            s.swap(arr);
            Console.WriteLine(arr);
            Console.WriteLine(string.Join(", ",arr));
            
           

        }
    }
}
