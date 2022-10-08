using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Base
{

    class person
    {
        public string name = "priya";
        public void show()
        {
            Console.WriteLine(name);
        }
    }

    class employee : person

    {
        public int salary = 70000;
        public void show()
        {
            Console.WriteLine(salary +" "+ base.name);//use1
        }
    }

    class manager : person
    {
        public void show()
        {
            int commition = 30000;
            Console.WriteLine("manager commition=" + commition);
            base.show();//base2
        }
    }

    class trainner : person
    {
        public trainner()
        {
            Console.WriteLine("fresher");
        }
    }

    class trainner2 : person
    {
        public trainner2() : base()//use3
        {
            Console.WriteLine("experince");
        }

    }

    class Basekeyword
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.show();
            manager m = new manager();
            m.show();
            trainner t = new trainner();
            trainner2 t2 = new trainner2();
        }
    }
}
        
    

