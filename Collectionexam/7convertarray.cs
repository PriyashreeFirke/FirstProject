using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _7convertarray
    {
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            List<int> list = array.ToList();
            Console.WriteLine(String.Join(",", list));

        }
    }
}

