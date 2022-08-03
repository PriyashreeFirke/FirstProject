using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class Vehicle
    {
        public int model_no;
        public string type;
        public int number_wheel;
        public int average;

        public void Accept(int emodel_no,string etype,int enumber_wheel)
        {
            model_no = emodel_no;
            type = etype;
            number_wheel = enumber_wheel;
            
        }
        public void Set_average()
        {
            if (number_wheel == 2)
            {
                Console.WriteLine("average is 10");

            }
            else if (number_wheel == 8)
            {
                Console.WriteLine("average is 20");

            }
            else if (number_wheel == 4)
            {
                Console.WriteLine("average is 15");
            }
        }
        public void Display()
        {
            Console.WriteLine(model_no+" "+type+" "+number_wheel);
        }
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Accept(1456, "bike", 2);
            
            v.Display();
            v.Set_average();
        }
    }
}
