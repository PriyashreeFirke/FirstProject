using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    class Removezero
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 0, 0, 1, 2, 0, 4, 0 };
            int[] result = approach(array);

        }
        static int[]approach(int[] array)
        {
            for(int i=0; i<array.Length;i++)
            {
                if (array[i] != 0)
                    continue;
                for (int j = i + 1; j < array.Length; j ++) 
                {
                    if (array[j] == 0)
                        continue;
                    array[i] = array[j];
                    array[j] = 0;
                    break;

                }
            }
            return array;
               

        }
    }
}
