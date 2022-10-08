using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _16stack
    {
        static void Main(string[] args)
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("pooja");
            stk.Push("priya");
            stk.Push("ria");

            foreach (string data in stk)
                Console.WriteLine(data);

            string v = stk.Peek();
            Console.WriteLine("data at stack top" + v);
            string d = stk.Pop();
            Console.WriteLine("remove element" + d);
            foreach (string data in stk)
                Console.WriteLine("*" + data);

        }
    }
}
