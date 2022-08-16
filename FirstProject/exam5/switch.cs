using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam5
{
    class @switch
    {
        static void Main(string[] args)
        {
            int opt;
            Console.WriteLine("/n options: \n");
            Console.WriteLine("1 India  \n 2 china\n 3 Banglandesh \n  4 Itly \n 5 united sttate\n 6 exit\n");
            Console.WriteLine("\n input your choice :");
            opt = Convert.ToInt32(Console.ReadLine());
             
                switch (opt)

            { 
            
                case 1:
                    Console.WriteLine("Hockey");
                    break;
                case 2:
                    Console.WriteLine("Table tannis");
                    break;
                case 3:
                    Console.WriteLine("kabbadi" );
                    break;
                case 4:
                    Console.WriteLine("Football" );
                    break;
                case 5:
                    Console.WriteLine("Baseball");
                    break;



                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }
    }
}
