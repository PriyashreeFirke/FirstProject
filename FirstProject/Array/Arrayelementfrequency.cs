using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Arrayelementfrequency
    {
        public static void Findoccurance(int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                   if (count == 1)//unique element display
                   //if(count >1)//duplicate element
                    {
                        Console.WriteLine(a[i] + "  " + count);
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter array element");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Arrayelementfrequency.Findoccurance(arr);
        }
    }
}
