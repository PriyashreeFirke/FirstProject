using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Contentment
{
    class Engine
    {
        string type;

        public Engine(string type)
        {
            this.type = type;
        }
        public void ShowAddress()
        {
            Console.WriteLine(" "+type+" ");
        }
    }
    class Car
    {
        int model_no;
        string cname;
        int price;
        Engine En;

        Car(int model_no, string cname, int price, Engine En)
        {
            this.model_no = model_no;
            this.cname = cname;
            this.price = price;
            this.En = En;
        }
        void Display()
        {
            Console.WriteLine(model_no+" "+cname+" "+price);
            En.ShowAddress();
        }
        static void Main(string[] args)
        {
            Engine e = new Engine("petrol");
            Car c;
            c = new Car(301, "BMW", 790000, e);
            c.Display();


        }
       

       
    }
}
