using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam7
{
    class Count
    {
        public static void Countarray(int[]arr,int n)
        {
             bool[] visited = new bool[n];
      
            for (int i = 0; i < n; i++)
            { 
                if (visited[i] == true)
                    continue;

               
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " " + count);
            }
        }
    
        static void Main(string[] args)
        {
            int[] a = new int[5];
            
            Console.WriteLine("enter element");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int n = a.Length;
            Count.Countarray(a,n);
            Console.WriteLine(a);
            Console.WriteLine(string.Join(",",a));
        }
    }
}
