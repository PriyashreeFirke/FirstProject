using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Hasarelationship
{
    class Engine
    {
        string type;


        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Car
    {
        int model_no;
        string cname;
        int price;
        Engine en;

        public int Model_no
        {
            get { return model_no; }
            set { model_no = value; }
        }
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
            
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Engine En
        {
            get { return en; }
            set { en = value; }
        }
    }
    class CarInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model_no = 567;
            c.Cname = "BMW";
            c.Price = 890000;
            c.En = new Engine();
            c.En.Type = "petrol";

            Console.WriteLine(c.Model_no+" "+c.Cname+" "+c.Price+" "+c.En.Type);
        }
    }
}
