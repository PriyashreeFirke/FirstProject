using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Min
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"enter {arr.Length}element in array");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int min = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if (min > arr[i])
                    min = arr[i];

            }
            Console.WriteLine("min"+min);
                
        }
    }
}
