using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Inheritance
{
    class Flower
    {
        internal string color = " Red";
    }
    class Rose:Flower
    {
        public void Show()
        {
            Console.WriteLine(color);
        }
    }
    class personinfonew
    {
        static void Main(string[] args)
        {
            Rose french = new Rose();
            french.Show();
            Console.WriteLine(french.color);

        }
    }
}
