using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{ 
    class EvenOdd
    {
       
            static void CountingEvenOdd(int[] arr, int arr_size)
            {
                int even_count = 0;
                int odd_count = 0;
                for (int i = 0; i < arr_size; i++)
                {

                    if (arr[i]%2 == 0)
                        even_count++;
                    else
                        odd_count++;
                }

                Console.WriteLine("Number of even"+ " elements = " + even_count+ " Number of odd elements = "+ odd_count);
            }

           
            public static void Main()
            {
                int[] arr = { 2, 3, 4, 5, 6 };
                int n = arr.Length;

                
                CountingEvenOdd(arr, n);
            }
        }
    }

