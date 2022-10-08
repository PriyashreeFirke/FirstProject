using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class Linklistdemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(100);
            l1.AddLast(200);
            l1.AddFirst(1000);

            foreach (int data in l1)
            Console.WriteLine(data);
        }
    }
}
