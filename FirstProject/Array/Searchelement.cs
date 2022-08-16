using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Searchelement
    {
        public static bool Findelement(int[] a, int n)
        {
            bool ispresent = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    ispresent = true;
                    break;

                }
            }
            return ispresent;
        }

        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("enter the element for search");
            int num = int.Parse(Console.ReadLine());
            bool isElementFound = Searchelement.Findelement(a, num);
            if (isElementFound == true)

            {
                Console.WriteLine("element present");

            }
            else
            {
                Console.WriteLine("not present");
            }
        }
    }
}
