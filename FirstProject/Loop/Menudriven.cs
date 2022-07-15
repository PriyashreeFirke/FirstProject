using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
    class Menudriven
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("enter 1st number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter 2nd nuber");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("1.addition \n2. substraction\n3.multipliation\n4.Divison");
                Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division" + (num1 / num2));
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
