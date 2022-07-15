using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class charswitch
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            switch (str)
            {
                case "happy":Console.WriteLine("aHappy");
                    break;
                case "new": Console.WriteLine("New");
                    break;
                case "year":Console.WriteLine("Year");
                    break;
                default: Console.WriteLine("welcome");
                    break;
            }
        }
    }
}
