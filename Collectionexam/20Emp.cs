using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _20Emp
    {
        static void Main(string[] args)
        {
            SortedList<Emp, string> ss = new SortedList<Emp, string>();
            ss.Add(new Emp(101, 6000, "IT"), "Ria");
            ss.Add(new Emp(102, 80000, "Finance"), "priya");
            ss.Add(new Emp(103, 40000, "IT"), "supriya");
            foreach (KeyValuePair<Emp, string> kv in ss)
                Console.WriteLine(kv.Key + "" + kv.Value);


        }
    }
    internal class Emp : IComparable<Emp>
    {

        int empno;
        int salary;
        string deptname;

        public Emp(int empno, int salary, string deptname)
        {
            this.empno = Empno;
            this.salary = Salary;
            this.deptname = deptname;
        }
        public int Empno { get => empno; set => empno = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Deptname { get => deptname; set => deptname = value; }


        public int CompareTo(Emp b2)
        {
            return b2.deptname.CompareTo(this.deptname);
        }
        public override string ToString()
        {
            return "empno:" + empno + "salary" + salary + "deptname:" + deptname;
        }
    }
}
