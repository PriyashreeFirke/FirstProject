using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Stringbuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("om");
            StringBuilder sb2 = new StringBuilder("om");
            Console.WriteLine(sb==sb2);
            Console.WriteLine(sb.Equals(sb2));
            sb.Append("rahul");
            sb.AppendLine("shree");
            sb.Remove(2, 2);
            sb.Insert(2, "priya");
            Console.WriteLine(sb[9]);

        }
    }
}
