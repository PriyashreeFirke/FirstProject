
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
    class series
    {
        static void Main(string[] args)
        {//2,5,10,17
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {

                    Console.WriteLine(i);//1,4,3,16
                    //Console.WriteLine(-i); -1,4,-3,16
                   // Console.WriteLine(i * i);//1,8,9,64
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(i * i);
                    //Console.WriteLine(i * i * i);
                }
                    
            }
        }
    }
}
