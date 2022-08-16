using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    class Engine
    {
        int id;
        int lastcleandate;
        
        public Engine(int id,int lastcleandate)
        {
            this.id=id;
            this.lastcleandate=lastcleandate;
        }
        public void showEngine()
        {
            Console.WriteLine(" "+id+" "+lastcleandate);
        }
        class subengine
        {
            string subenginetype;
            public subengine(string subenginetype)
            {
                this.subenginetype = subenginetype;
            }
            public void showengine()
            {
                Console.WriteLine(" "+subenginetype);
            }
         class Gear
            {
                string geartype;
                public Gear(string geartype)
                {
                    this.geartype = geartype;
                }
                public void showgear()
                {
                    Console.WriteLine(" "+geartype);
                }
          class Car
                {
                    int id;
                    string color;
                    public Car(int id,string color)
                    {
                        this.id = id;
                        this.color = color;

                    }
                   public void Displaycall()
                    {
                        Console.WriteLine(id+" "+color);
                    }
                }
                static void Main(string[] args)
                {
                    Engine e = new Engine(111, 23);
                    subengine s = new subengine("petrol");
                    Gear g = new Gear("auto");
                    Car c = new Car(61, "White");
                    c.Displaycall();
                }
            }
        }
       
    }
}
