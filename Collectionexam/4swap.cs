using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
   public static  class Example
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

     class _4swap
{
        public static void Main()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            nums.Swap(2, 3);
            Console.WriteLine(String.Join(", ", nums));    
        }
    }
}

