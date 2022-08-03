using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oopsencapsulation
{
    class Car
    {
        int number;
        string name;
        string color;
        int price;
        int speed;
        public int NUMBER
        {
            get { return number;}
            set { number = value;}
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public string COLOR
        {
            get { return color; }
            set { color = value; }
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
    }class carinfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.NUMBER=100;
            c.NAME = "ria";
            c.COLOR = "red";
            c.PRICE = 200000;
            c.SPEED = 200;
            Console.WriteLine(c.NUMBER);
            Console.WriteLine(c.NAME);
            Console.WriteLine(c.COLOR);
            Console.WriteLine(c.PRICE);
            Console.WriteLine(c.SPEED);

        }
    }
}
