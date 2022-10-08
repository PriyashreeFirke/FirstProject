using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class Listdemo
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            Console.WriteLine(lst.Count);//0
            Console.WriteLine(lst.Capacity);//0 
            lst.Add("viraj");
            lst.Add("ria");
            lst.Add("priya");
            Console.WriteLine(lst.Count);//3
            Console.WriteLine(lst.Capacity);//4 default size of list
            lst.Insert(1, "komal");
            lst[1] = "ria";
            lst.RemoveAt(1);//index
            lst.Remove("priya");
            for(int i=0;i<lst.Count;i++)
            {
                Console.Write(lst[i]+" ");
            }
            Console.WriteLine();
            for(int i=lst.Count-1;i>=0;i--)
            {
                Console.WriteLine(lst[i]+"");
            }
            foreach(string s in lst)
            {
                Console.WriteLine(s+"");
            }
        }
    }
}
