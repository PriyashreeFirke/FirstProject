using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Accessmodifier
{
    class studentdemo:student
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            Console.WriteLine("information of student");
            
            s1.Accept2();
            s1.Accept3();
           

            studentdemo m = new studentdemo();
            m.Accept4();
            

        }
    }
}
