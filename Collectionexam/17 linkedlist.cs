using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
   

        class Department
        {
            int deptid;
            string deptname;

            public Department(int deptid, string deptname)
            {
                this.deptid = deptid;
                this.deptname = deptname;
            }

                public int Deptid { get => deptid; set => deptid = value; }
            public string Deptname { get => deptname; set => deptname = value; }
        }
        
        class Department1
        {
            int eno;
            string ename;
            int salary;
            Department d;

            public Department1(int deptid, string deptname,int salary,Department d)
            {
                this.eno = eno;
                this.ename = ename;
                this.salary = salary;
                this.d = d;
            }
        public int Eno { get => eno; set => eno = value; }
        public string Ename { get => ename; set => ename = value; }
        public int Salary { get => salary; set => salary = value; }
        internal Department D { get => d; set => d = value; }

        public override string ToString()
            {
                return "eno:" + eno + "ename:" + ename + "salary:" + salary + "departdetail"+d;
            }
            
        
        class _17_linkedlist
        {
        
            static void Main(string[] args)
            {
                LinkedList<Emp> Lk = new LinkedList<Emp>();
               /// Lk.AddFirst(new Emp(1, "raj",3000, new Department(1, "IT")));
               // Lk.AddFirst(new Emp(2, "raj", 6000, new Department(1, "IT")));
               // Lk.AddFirst(new Emp(4, "raj", 4000, new Department(1, "IT")));
            }
        }
    }
}
