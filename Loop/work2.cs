using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
    class work2
    {
        static void Main(string[] args)
        {
            int count = 0;

            for(int i=1; i<=10;i++)
            {
                if (i % 2 != 0)
                {
                    count = ++count;


                    Console.WriteLine(count);
                }
            }
        }
    }
}
