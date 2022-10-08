using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _8reverse
    {
        static void Main(string[] args)
        {


            List<string> l1 = new List<string>(5);
            l1.Add("priya");
            l1.Add("ria");
            l1.Add("sweta");
            l1.Add("tina");


            Console.WriteLine("Original List items");


            foreach (string a in l1)
                Console.WriteLine(a);


            l1.Reverse();

            Console.WriteLine();

            foreach (string a in l1)
                Console.WriteLine(a);
        }
    }
}
