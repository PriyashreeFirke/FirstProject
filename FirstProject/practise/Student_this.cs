using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class Student_this
    {
        int id;
        string name;
        string subject;
        int marks;
        Student_this(int id, string name, string subject, int marks)
        {
            this.id = id;//1 use
            this.name = name;
            this.subject = subject;
            this.marks = marks;
            this.show();// 2use
        }
        public void show()

        {
            Console.WriteLine(id + "" + name + " " + subject + " " + marks);

        }
        public Student_this() : this(1, "ria", "english", 40)//3use
        {
            if (marks < 50)
            {
                Console.WriteLine("Fail");
            }
        }
            static void Main(string[] args)
            {
                Student_this s = new Student_this();
            }

        }
    }

