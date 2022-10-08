using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
    class menudrivenday
    {
        static void Main(string[] args)
        {
            char ch;
            do
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

                Console.WriteLine("Do you want to continue......");
                ch = Convert.ToChar(Console.ReadLine());
            }

            while (ch == 'y' || ch == 'Y');

        }
    }
}
