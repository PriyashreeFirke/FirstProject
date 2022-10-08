using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam7
{
    class Zeroremove
    {
        public static void Removezerofromnonzero(int[]arr)
        {
            int j = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]!=0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                        arr[i] = temp;
                    j++;


                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 12, 0, 7, 0, 8, 0, 3 };
            Zeroremove.Removezerofromnonzero(a);
            Console.WriteLine(a);
            Console.WriteLine(string.Join(",", a));

        }
    }
}
