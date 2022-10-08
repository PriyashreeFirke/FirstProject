using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Online
{
    class Passbyvalue
    {
        public void Swap(ref int num1,ref  int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Main(string[] args)
        {
            Passbyvalue p = new Passbyvalue();
            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+" "+num2);
            Console.WriteLine("...............");
           // p.Swap(num1, num2);//pass by value
            p.Swap(ref num1, ref num2);//pass by refrence
            Console.WriteLine(num1+""+num2);

        }

    }
}
