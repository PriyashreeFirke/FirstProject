using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class STRINGhw
    {
        static void Main(string[] args)
        {
            string mystr = "Priyashree";
            int vowelcount = 0;
            int conscount = 0;
            for(int i=0;i<mystr.Length;i++)
            {
                if(mystr[i]=='a' || mystr[i]=='e'|| mystr[i]=='i'|| mystr[i]=='o'||mystr[i]=='u')
                {
                    vowelcount++;
                }
                else
                {
                    conscount++;
                }
            }
            Console.WriteLine("vowel is"+ vowelcount);
            Console.WriteLine("consonent is"+conscount);
            for(int i=mystr.Length-1;i>=0;i--)
            {
                Console.WriteLine(mystr[i]);
            }


        }
    }
}
