using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Overloading
{
    class Calculator
    {
       
        int calculator(int a, int b)
        {
            return a + b;
        } 
         float calculator(float a, float b)
        {
            return a - b; 
        }
        double calculator (double a, double b)
        {

            return  a * b;
        }
         double  calculator(int a, double b)
        {
            return a %b;
        }
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine("addition= "+ c.calculator(4,6));
            Console.WriteLine("subtraction= " + c.calculator(2f, 6f));
            Console.WriteLine("multiplication= "+c.calculator(5,5));
            Console.WriteLine("Division = " + c.calculator(6, 2));
        }
    }
}
