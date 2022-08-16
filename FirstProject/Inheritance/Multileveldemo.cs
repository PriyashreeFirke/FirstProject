using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Inheritance
{
    class Person
    {
        internal string p_name = "amit";
        public void Showperson()
        {
            Console.WriteLine("Name="+p_name);
        }
    }
    class Employee : Person
    {
        internal int salary = 70000;
        public void showsalary()
        {
            Console.WriteLine(p_name+" "+salary);
        }
    }
    class manager : Employee
    {
        int commition = 3000;
        public void showmanager()
        {
            Console.WriteLine(p_name+" "+salary+" "+commition);
        }
    }
    



    class Multileveldemo
    {
        static void Main(string[] args)
        {
            manager m = new manager();
            m.Showperson();
            m.showsalary();
            m.showmanager();
        }
    }
}
