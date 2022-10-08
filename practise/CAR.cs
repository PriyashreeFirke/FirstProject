using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class CAR
    {
        public int model_number;
        public string car_name;
        public int car_price;
        public string car_color;
        static void Main(string[] args)
        {
            CAR audi = new CAR();
            audi.model_number = 2345;
            audi.car_name = "Audi";
            audi.car_price = 700000;
            audi.car_color = "Black";
            Console.WriteLine(audi.model_number+" "+audi.car_name+" "+audi.car_price+" "+audi.car_color);

            CAR BMW = new CAR();
            audi.model_number = 6789;
            audi.car_name = "BMW";
            audi.car_price = 800000;
            audi.car_color = "Blue";
            Console.WriteLine(audi.model_number + " " + audi.car_name + " " + audi.car_price + " " + audi.car_color);

            CAR i10 = new CAR();
            audi.model_number = 9067;
            audi.car_name = "i10";
            audi.car_price = 500000;
            audi.car_color = "Red";
            Console.WriteLine(audi.model_number + " " + audi.car_name + " " + audi.car_price + " " + audi.car_color);

        }
    }
}
