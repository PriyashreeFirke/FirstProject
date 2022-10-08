using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Abstraction
{
    interface IDrawble
    {
        void Draw();
    }
    /*interface IPrintable
    {
        void print();
    }*/
    abstract class Circle
    {
        class Shape : Circle, IDrawble
        {
            public void Draw()
            {
                Console.WriteLine("draw shape"); ;
            }
            public void print()
            {
                Console.WriteLine("print shape");
            }
        }

        class Interfacedemo2
        {
            static void Main(string[] args)
            {
                Shape s = new Shape();
                s.Draw();
                //s.print();
            }
        }
    }
}
