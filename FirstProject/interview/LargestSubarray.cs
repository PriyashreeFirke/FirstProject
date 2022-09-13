using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class LargestSubarray
    {
        static public int largestsubarray2(int[]arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int z = 0, one = 0;
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j] == 1)
                        one++;
                    else
                        z++;
                    if (z == one)
                    {
                        if (max < (j - i + 1))
                            max = j - i + 1;
                    }
                }

            }
            return max;
        }
        static void Main(string[] args)
        {
            int max = largestsubarray2(new int[] { 1, 1, 1, 0, 0, 0 });
            Console.WriteLine(max);
        }
    }
}
