using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    class Question3
    {
        public static char Frequency(char[] arr, char n)
        {
            int mincount = 0;
            char min_freq = arr[0];
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count < mincount)
                {
                    mincount = count;
                    min_freq = arr[i];
                }
            }

            return min_freq;
        }

        public static void Main(String[] args)
        {
            char[] arr = { 'a', 'b', 'b', 'c', 'c', 'b' };
            char n = (char)arr.Length;
            Console.WriteLine("Minimum Frequency Element:" + Frequency(arr, n));
        }
    }

}

