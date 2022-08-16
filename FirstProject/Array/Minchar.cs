using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Array
{
    class Minchar
    {
       
            public static char FindMin(char[] ch)
            {
                char min = ch[0];
                foreach (int x in ch)
                {
                    Console.WriteLine((char)(x) + "  " + x);
                }
                for (int i = 0; i < ch.Length; i++)
                {
                    if (min > ch[i]) ;
                {
                    min = ch[i];
                }
                }
                return min;
            }
            static void Main(string[] args)
            {
                char[] c = { 'a', 'b', 'b', 'c', 'c','b' };
            char minvalue = Minchar.FindMin(c);
                Console.WriteLine("Min charater from array" + minvalue);
            }


        }
    }



