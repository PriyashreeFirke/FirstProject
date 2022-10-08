﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class Demoqueue
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(50);

            int d = q.Dequeue();//remove first element from queue
            Console.WriteLine(d);
            int p = q.Peek();
            foreach (int element in q)
                Console.WriteLine(element);
        }
    }
}
