using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _14dic
    {
        static void Main(string[] args)
        {
            Student t1 = new Student(1, "priyashree");
            Student t2 = new Student(2, "ria");

            Console.WriteLine(t1.GetHashCode());
            Console.WriteLine(t2.GetHashCode());
            Dictionary<Student, int> s1 = new Dictionary<Student, int>();
            s1.Add(new Student(1, "priyashree"), 6000);
            s1.Add(new Student(2, "ria"), 5000);
            s1.Add(new Student(3, "ria"), 2000);

            Console.WriteLine(s1.Count);
            foreach (KeyValuePair<Student, int> kv in s1)
            {
                Console.WriteLine(kv.Key + ".." + kv.Value);
            }
        }
        class Student
        {
            int studentid;
            string studentname;

            public override int GetHashCode()
            {
                return HashCode.Combine(studentid, studentname);
            }
            public override bool Equals(object obj)
            {
                Student s2 = (Student)obj;
                return this.studentid == s2.studentid && this.studentname == s2.studentname;
            }
            public Student(int studentid, string studentname)
            {
                this.studentid = studentid;
                this.studentname = studentname;
            }
            public override string ToString()
            {
                return $"studentid:{studentid} studentname:{studentname}";
            }

        }
    }
}
