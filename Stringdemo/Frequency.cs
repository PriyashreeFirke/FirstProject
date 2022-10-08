using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Frequency
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter string");
            string n = Console.ReadLine();
            int[] freq = new int[n.Length];
          

            for (int i = 0; i < n.Length; i++)
            {
               freq[i] = 0;
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[i] == n[j])
                    {
                        freq[i]++;
                    }
                }
            }
            for (int i = 0; i < freq.Length; i++)
            {
            }
               
                Console.WriteLine( string.Join(",",freq));
            

                    

           
        }
    }
}

