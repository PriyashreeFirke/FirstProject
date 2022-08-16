using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class Celcius
    {
        static void Main(string[] args)
        {
            double celsisus;
            double fahrenheit = 97;
            Console.WriteLine("Fahrenheit"+ fahrenheit);
            celsisus = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsisus" + celsisus);
            Console.ReadLine();
        }
    }
}
