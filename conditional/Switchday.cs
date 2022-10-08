using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class Switchday
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1.area of rectangle \n2. area of circle\n3. area of trinagle\n4. area of square");
            Console.WriteLine("enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter  number");
                    int width = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter 2nd nuber");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of rectangle" + (width*height));
                    
                    break;
                case 2:
                    Console.WriteLine("enter  number");
                    int R = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of circle" + (3.14 *R * R));
                    break;
                case 3:
                    Console.WriteLine("enter  number");
                    int breath = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter 2nd nuber");
                    int Height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of traingle" + (breath * Height)/2);
                    break;
                case 4:
                    Console.WriteLine("enter  number");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of square" + (side*side));
                    break;


                default:
                    Console.WriteLine("Invalid choice");
                    break;




            }


        }

    }
}
