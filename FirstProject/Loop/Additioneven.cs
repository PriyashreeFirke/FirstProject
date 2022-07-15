using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
    class Additioneven
    {
        static void Main(string[] args)
        {
            //print addition of even number between 1 to 10
            int sum = 0;
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + 1;
                }
                    
                

            }
            Console.WriteLine(sum);
                   

        }
    }
}
