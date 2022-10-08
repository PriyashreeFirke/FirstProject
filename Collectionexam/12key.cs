using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _12key
    {
        public static void Main()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(1, "One");
            d.Add(2, "Two");
            d.Add(3, "Three");
            d.Add(4, "Four");

            List<int> keys = new List<int>(d.Keys);
            Console.WriteLine("Displaying keys...");
            foreach (int res in keys)
            {
                Console.WriteLine(res);
            }
        }
    }
}

