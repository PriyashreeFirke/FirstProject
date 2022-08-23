using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam7
{
    class positive
    {
        static void fill1(int[] a, int neg, int pos)
        {
            if (neg % 2 == 1)
            {
                for (int i = 1; i < neg; i += 2)
                {
                    int c = a[i];
                    int d = a[i + neg];
                    int temp = c;
                    a[i] = d;
                    a[i + neg] = temp;
                }
            }
            else
            {
                for (int i = 1; i <= neg; i += 2)
                {
                    int c = a[i];
                    int d = a[i + neg - 1];
                    int temp = c;
                    a[i] = d;
                    a[i + neg - 1] = temp;
                }
            }
        }

        // Function which works in the condition when number of
        // negative numbers are greater than positive numbers
        static void fill2(int[] a, int neg, int pos)
        {
            if (pos % 2 == 1)
            {
                for (int i = 1; i < pos; i += 2)
                {
                    int c = a[i];
                    int d = a[i + pos];
                    int temp = c;
                    a[i] = d;
                    a[i + pos] = temp;
                }
            }
            else
            {
                for (int i = 1; i <= pos; i += 2)
                {
                    int c = a[i];
                    int d = a[i + pos - 1];
                    int temp = c;
                    a[i] = d;
                    a[i + pos - 1] = temp;
                }
            }
        }

        // Reverse the array

        static void reverse(int[] a, int n)
        {
            int i, k, t;
            for (i = 0; i < n / 2; i++)
            {
                t = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = t;
            }
        }

        // Print the array
        static void print(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        // Driver Code
        public static void Main(string[] args)
        {

            // Given array
            int[] arr = { 2, 3, -4, -1, 6, -9 };
            int n = arr.Length;
            Console.WriteLine("Given array is  ");
            print(arr, n);
            int neg = 0, pos = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                    neg++;
                else
                    pos++;
            }

          

            if (neg <= pos)
            {
                fill1(arr, neg, pos);
            }
            else
            {
                // reverse the array in this condition
                reverse(arr, n);
                fill2(arr, neg, pos);
            }
            Console.WriteLine("Rearranged array is  ");
            print(arr, n);
        }
    }

}

