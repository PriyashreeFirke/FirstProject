using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class Cukoo
    {
        static int Cuckoo(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
                return 1 * Cuckoo(n - 1) + 2 * Cuckoo(n - 2) + 3 * 1;
        }
        static void Main(string[] args)
        {
            int result = Cuckoo(4);
        }
    }
}
