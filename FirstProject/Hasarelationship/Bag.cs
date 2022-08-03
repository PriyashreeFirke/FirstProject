using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Hasarelationship
{
    class pen
    {
        int length;
        string name;
        string type;
        string color;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
    class Bag
    {
        string brandname;
        int price;
        string color;
        pen p;

        public string Brandname
        {
            get { return brandname; }
            set { brandname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public pen P
        {
            get { return p; }
            set { p = value; }
        }
    }
    class BagInfo
    {
        static void Main(string[] args)
        {
            Bag b = new Bag();
            b.Brandname = "wildcraft";
            b.Price = 670;
            b.Color = "red";
            b.P = new pen();
            b.P.Length = 5;
            b.P.Name = "penteck";
            b.P.Color = "blue";
            b.P.Type = "ink";

            Console.WriteLine(b.Brandname+" \n"+b.Price+"\n "+b.Color+"\n "+b.P.Length+" \n"+b.P.Name+" \n"+b.P.Color+"\n "+b.P.Type);

        }
    }
}
