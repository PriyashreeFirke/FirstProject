using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.breakcontinue
{
    class Break
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    // break;
                    continue;
                }
                Console.WriteLine(i);

            }
        }
    }
}
