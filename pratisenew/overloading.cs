using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.pratisenew
{
    class A

    {
        int x;

        public A(int x)
        {
            this.x = x;
        }
        public virtual void m1()
        {
            Console.WriteLine("run fast");
        }

        public void playsong()
        {
            Console.WriteLine("hello");
        }
        public static void disp()
        {
            Console.WriteLine("om");
        }
    }
    class B : A
    {
        public B() : base(2)
        {

        }
        public override void m1()
        {
            Console.WriteLine("run slow");
        }
        //method hiding
        public void playsong()
        {
            Console.WriteLine("hi");
        }
        //method hiding
        public static void disp()
        {
            Console.WriteLine("hari");
        }
    }
    class overloading
    {
        static void Main(string[] args)
        {
            A a = new B();//run it will decide which object is formed and which will excute
            a.m1();
            a.playsong();//will rum parent method because no overriding
            A.disp();//parent call
            B.disp();//child call
        }
    }

    class Vechicle
    {
        string vname;
        int cost;
        public Vechicle(string vname, int cost)
        {
            this.vname = vname;
            this.cost = cost;
        }
        public void show()
        {
            Console.WriteLine(vname + "" + cost);
        }
    }
    class person
    {
        string name;
        string email;
        Vechicle v;

        public person(string name, string email, Vechicle v)
        {
            this.name = name;
            this.email = email;
            this.V = v;
        }
        void display()
        {
            Console.WriteLine(name + "" + email + "" + v);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Vechicle V
        {
            get { return v; }
            set { v = value; }
        }
        static void Main(string[] args)
        {
            Vechicle v = new Vechicle("activa", 30000);
            v.show();
            person p = new person("priya", "@gmail.com", v);
            p.display();

        }


    }
}
