using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Overloading
{
    class Area
    {
        int area(int l, int w)
        {
            return (l * w);
        }
        double area(double b, double h)
        {
            return (b * h) / 2;
        }
        int area(int s)
        {
            return (s * s);
        }
        double area (double r)
        {
            return (3.14 * r * r);
        }
        static void Main(string[] args)
        {
            Area a = new Area();
            Console.WriteLine("area of rectangle= "+a.area(6,2));
            Console.WriteLine("area of traingle= "+a.area(4.2,6.4));
            Console.WriteLine("area of square= "+a.area(6));
            Console.WriteLine("area of circle= "+a.area(4.2));
        }
    }
}
