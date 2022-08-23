using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    class Car
    {
        int id;
        string color;
        Engine en;
        

        Car(int id, string color)
        {
            this.id = id;
            this.color = color;
        }
        public void Show()
        {
            Console.WriteLine(" " + id + " " + color);
        }

        class Engine
        {
            int id;
            int date;
            Subengine se;

            public Engine(int id, int date)
            {
                this.id = id;
                this.date = date;
            }
            public void ShowEngine()
            {
                Console.WriteLine(" " + id + " " + date);
            }

            class Subengine
            {
                string type;
                public Subengine(string type)
                {
                    this.type = type;
                }
                public void Showsub()
                {
                    Console.WriteLine(" " + type + " ");
                }
                class Gear
                {
                    string type;
                    public Gear(string type)
                    {
                        this.type = type;

                    }
                    public void Display()
                    {
                        Console.WriteLine(" " + type + " ");
                    }

                    static void Main(string[] args)
                    {
                        Engine e;
                        Car c = new Car(101, "red");
                        new Engine(121, 12 / 12 / 21);
                        Subengine s = new Subengine("auto");

                     
                    }
                }
            }
        }
    }
}




        
















      