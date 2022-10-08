using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstProject.collection
{
    class linkedlistdemo1
    {
        static void Main(string[] args)
        {
            LinkedList<int> lk = new LinkedList<int>();
            lk.AddFirst(90);
            lk.AddLast(32);
            lk.AddLast(52);

            LinkedListNode<int> node = lk.Find(32);
            if (node != null)
            {
                lk.AddBefore(node, 100);
                lk.Remove(52);
                foreach (int data in lk)
                    Console.WriteLine(data);
                for (int i = 0; i < lk.Count; i++)
                {
                    Console.WriteLine(lk.ElementAt(i));
                }

            }
        }
    }
}
