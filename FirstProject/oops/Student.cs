using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class Student
    {
        public int id;
        public string name;
        public double marks;

        static void Main(string[] args)
        {
            Student stud1 = new Student();

            stud1.id = 101;
            stud1.name = "amit";
            stud1.marks = 98.65;
            Console.WriteLine(stud1.id+" "+stud1.name+" "+stud1.marks);
        }
}

    }

