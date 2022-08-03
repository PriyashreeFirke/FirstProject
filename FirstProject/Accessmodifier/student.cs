using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Accessmodifier
{
    class student
    {
        private int rollnumber =101;
        internal string name="ria";
        public string address="pune";
        protected int marks=78;

        private void Rollnumber()
        {
            Console.WriteLine(rollnumber);

        }
        internal void Accept2()
        {
            Console.WriteLine(name);
           
        }
        public void Accept3()
        {
            Console.WriteLine(address);
            
        }
        protected void Accept4( )
        {
            Console.WriteLine(marks);
            
        }
        static void Main(string[] args)
        {
            student s = new student();
            s.Rollnumber();
            s.Accept2();
            s.Accept3();
            s.Accept4();

            
        }
    }
}
