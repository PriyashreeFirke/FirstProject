using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class switchoperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enterv 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter operator");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Addition" + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("substraction" + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("multiplication" + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("divison" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;

            }
        }
    }
}
