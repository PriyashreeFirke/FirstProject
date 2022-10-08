using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _5replace
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();

            lst.Add("viraj");
            lst.Add("ria");
            lst.Add("priya");
            lst[2] = "neeraj";
            foreach (string s in lst)
            {
                Console.WriteLine(s + "");
            }
        }
    }
}