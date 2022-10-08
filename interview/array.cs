using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class array
    {
        static void Main(string[] args)
        {
            string str = "Thinkquotient";
            int[] freq = new int[str.Length];
            int i, j, high=0;

            char[] string1 = str.ToCharArray();

            for( i=0;i<string1.Length;i++)
            {
                freq[i] = 1;
                for (j = i + 1; j < string1.Length; j++) ;
                {
                    if(string1[i]==string1[j])
                    {
                        freq[i]++;
                    }
                }
            }
            if(high<freq[i])
            {
                high = freq[i];
                char max = str[0];
            }
            Console.WriteLine(char.MaxValue );
            
        }
    }
}
