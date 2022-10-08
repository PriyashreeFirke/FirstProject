using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class Animal
    {
        public string name;
        public int legs;
        public string food_type;
        static void Main(string[] args)
        {
            Animal one = new Animal();
            one.name = "Tiger";
            one.legs = 4;
            one.food_type = "Meat";
            Console.WriteLine(one.name+" "+one.legs+" "+one.food_type);

            Animal two = new Animal();
            two.name = "rabbit";
            two.legs = 4;
            two.food_type = "carrot";
            Console.WriteLine(two.name+" "+two.legs+" "+two.food_type);

        }
    }
}
