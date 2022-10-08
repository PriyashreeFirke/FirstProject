using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _13value
    {
        public static void Main()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(1, "One");
            d.Add(2, "Two");
            d.Add(3, "Three");
            d.Add(4, "Four");

           // List<int> value = new List<int>(d.Value);
            Console.WriteLine("Displaying keys...");
           // foreach (int res in value)
            {
               // Console.WriteLine(res);
            }
        }
    }
}
