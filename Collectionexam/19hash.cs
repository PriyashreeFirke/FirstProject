using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _19hash
    {
        static void Main(string[] args)
        {


            HashSet<string> hs = new HashSet<string>();
            hs.Add("priyashree");
            hs.Add("ria");
            hs.Add("puja");
            hs.Add("ria");
            foreach (string s in hs)
            {
                Console.WriteLine(hs);


            }
        }
}
}
