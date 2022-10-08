using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class Carencapsulation
    {
       
            int model_number;
            string name;  
            int price;
            int speed;
            public int MODEL_NUMBER
            {
                get { return model_number; }
                set { model_number = value; }
            }
            public string NAME
            {
                get { return name; }
                set { name = value; }
            }
            
            public int PRICE
            {
                get { return price; }
                set { price = value; }
            }
            public int SPEED
            {
                get { return speed; }
                set { speed = value; }
            }
        }
        class carinfo
        {
            static void Main(string[] args)
            {
                Carencapsulation c = new Carencapsulation();
                c.MODEL_NUMBER = 100;
                c.NAME = "audi";
                c.PRICE = 200000;
                c.SPEED = 200;
                Console.WriteLine(c.MODEL_NUMBER);
                Console.WriteLine(c.NAME);
                Console.WriteLine(c.PRICE);
                Console.WriteLine(c.SPEED);

            }
        }
    }


