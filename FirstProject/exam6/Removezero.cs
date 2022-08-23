using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    class Removezero
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 26, 0, 67,45, 0, 78, 54, 38,10,0,34 };
                       for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            for(int j=0; j<array.Length;j++)
            {
                if (array[j] == 0)
                {
                   array[j] = 1;
                  
                }
                Console.Write(array[j]);
            }
           
               

        }
    }
}
