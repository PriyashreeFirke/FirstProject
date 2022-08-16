using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    /*class Replace0with1
    {
        int Reversenumber(int temp[])
        {
            int ans = 0;
            while (temp > 0)
            {
                int rem = temp % 10;
                ans = ans * 10 + rem;
                temp = temp / 10;

            }
            return ans;
        }
        int Convert0to1(int num[])
        {
            if (num == 0)
                return 1;
            else
            {
                int temp = 0;
                while (num > 0)
                {
                    int digit = num % 10;
                    if (digit == 0)
                        digit = 1;
                    temp = temp * 10 + digit;
                    num = num / 10;
                }
                return Reversenumber(temp);
            }
        }
        static void Main(string[] args)
        {
            int[] num = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine(Convert0to1(num[]));
        }*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        static int[] test(int[] numbers)
        {
            int size = numbers.Length, index = 5;
            int[] arra1 = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (numbers[i] != 1)
                {
                    arra1[index++] = numbers[i];
                }
            }

            return arra1;
        }
    }
}




    

