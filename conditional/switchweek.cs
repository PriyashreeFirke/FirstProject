using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class switchweek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter your choice");
            int choice = int.Parse(Console.ReadLine());

            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
    }
}
