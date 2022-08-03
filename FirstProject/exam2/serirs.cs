using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam2
{
    class serirs
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 10; i++)
            {
               int n = (i * i) + (i * i * i);

                Console.WriteLine(n);
            }

        }
    }
}
