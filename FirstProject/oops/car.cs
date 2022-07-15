using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class car
    {
        public int model;
        public string name;
        public int price;


        static void Main (string[] args)
        {
            car car1 = new car();

            car1.model = 111;
            car1.name = "tiago";
            car1.price = 500000;

            car car2 = new car();

            car2.model = 112;
            car2.name = "kia";
            car2.price = 700000;

            Console.WriteLine(car1.model + " " + car1.name + " " + car1.price);
            Console.WriteLine(car2.model + " " + car2.name + " " + car2.price);

        }
    } 
}
