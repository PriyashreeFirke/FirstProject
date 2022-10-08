using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam5
{

    class Demo
    {
        public static void main(String[] args)
        {
            Car c1 = new Car();
            //c1.color = "Blue";
            Car c2 = new Car();
            c2.changeColor(c1);
            //c2.color = "Pink";
            //Console.WriteLine(c1.color);
            // Console.WriteLine(c2.color);
        }
    }
        
        class Car
        {
            String color;
            public void changeColor(Car c2)
            {
                c2.color = color;
                color = "Red";
            }
        }

    }

