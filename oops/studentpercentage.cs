using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class studentpercentage
    {
        public int id;
        public string name;
        public int  m1marks, m2marks,m3marks;
        public int total;
        public int percentage;

        public void AcceptDetailS( int sid,string sname,int sm1marks, int sm2marks, int sm3marks)
        {
            id = sid;
            name = sname;
            m1marks = sm1marks;
            m2marks = sm2marks;
            m3marks = sm3marks;

        }
          public void calculate()
        {
             total = m1marks + m2marks + m3marks;
             percentage = (total * 100) / 3;
        }

        public void Display()
        {
            Console.WriteLine(id+" "+name+" "+m1marks+" "+m2marks+" "+m3marks);
            Console.WriteLine( total+" "+percentage);
        }

        static void Main(string[] args)
        {
            studentpercentage e = new studentpercentage();
            e.AcceptDetailS(101,"ria",40,60,50);
            e.calculate();
            e.Display();
        }
    }

}
