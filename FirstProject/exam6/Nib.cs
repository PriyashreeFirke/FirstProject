using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam6
{
    class Nib
    {
        string materialType;
        int width;

        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Refill
    {
        string inkcolor;
        int length;
        Nib n;
        public string Inkcolor
        {
            get { return inkcolor; }
            set { inkcolor = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib N
        {
            get { return n; }
            set { n = value; }
        }


    }
    class Program4
    {

        int capLength;
        string brand;
        Refill r;



        public int CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Refill R
        {
            get { return r; }
            set { r = value; }
        }
    }
    class PenInfo
    {
        static void Main(string[] args)
        {
            Program4 p = new Program4();
            p.CapLength = 5;
            p.Brand = "Nataraj";
            p.R = new Refill();
            p.R.Inkcolor = "blue";
            p.R.Length = 10;
            p.R.N = new Nib();
            p.R.N.MaterialType = "Steel";
            p.R.N.Width = 2;

            Console.WriteLine("Cap Length: " + p.CapLength + "Brand:" + p.CapLength + "Ink color: " + p.R.Inkcolor +
                "Refill Length: " + p.R.Length + "Material Type:" + p.R.N.MaterialType + "Width: " + p.R.N.Width);

        }

    }

}



