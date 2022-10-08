using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam7
{
    class Merg
    {
        public void MergArray(int[]A,int[]B,int[]res)
        {
            int indexa = 0;
            int indexb = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if(indexa<A.Length && A[indexa]<=B[indexb])
                {
                    res[i] = A[indexa];
                    indexa++;
                }
                else
                {
                    if (indexb < B.Length)
                    {
                        res[i] = B[indexb];
                        indexb++;
                    }
                }
            }   


        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr1 = { 11, 22, 33, 44 };
            int[] res = new int[arr.Length + arr1.Length];
            Merg m = new Merg();
            
            m.MergArray(arr, arr1, res);
            Console.WriteLine(res);
            Console.WriteLine(string.Join(",",res));


        }
    }
}
