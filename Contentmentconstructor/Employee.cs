using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Contentmentconstructor
{
    class Department
    {
        int Did;
        string name;

        public Department(int Did, string name)
        {
            this.Did=Did;
            this.name = name;
        }
        public void show()
        {
            Console.WriteLine(Did+" "+name);
        }
    }
    class Employee
    {
        int id;
        string name;
        int salary;
        Department dp;

        Employee(int id, string name, int salary, Department dp)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.dp = dp;
        }

        void Display()
        {
            Console.WriteLine(id+""+name+" "+salary);
            dp.show();
        }
        static void Main(string[] args)
        {
            Department t = new Department(201, "science");
            Employee E;
            E = new Employee(101, "priya", 700000,t);
            E.Display();
        }
    }
}
