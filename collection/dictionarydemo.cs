using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class dictionarydemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d1 = new Dictionary<string, int>();
            d1.Add("priya", 21);
            d1.Add("ria", 61); 
            d1.Add("piyashree", 78);
            Console.WriteLine(d1["priya"]);
            d1["priya"] = 71;
            d1.Remove("ria");
            Console.WriteLine(d1.ContainsKey("mithi"));
            Console.WriteLine(d1.ContainsValue(78));
            foreach(KeyValuePair<string,int> kv in d1)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
        }
    }
}
