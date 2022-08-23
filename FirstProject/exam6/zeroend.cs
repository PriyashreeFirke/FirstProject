using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    class zeroend
    {


        static void Main(string[] args)
        {
            int[] A = { 12,0,7,0,8,0,3 };
          
            int j = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != 0)
                {
                    int temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                    j++;
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
                Console.Write(" ");
            }
        }
    }
}
           
        
    

