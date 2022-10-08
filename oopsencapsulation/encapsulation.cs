using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oopsencapsulation
{
    class encapsulation
    {

        int id;
        string name;
        float percentage;
        bool isstudent ;

        public int ID
        {
            get { return id; }
            set { id = value; }

        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public float PERCENTAGE
        {
            get { return percentage; }
            set { percentage = value; }
        }
        public bool Status
        {

            get { return isstudent; }
            set { isstudent = value; }
        }
    } class info
            {
                static void Main(string[] args)
                {
                    encapsulation e = new encapsulation();
                    e.ID = 101;
                    e.NAME = "priya";
                    e.PERCENTAGE = 66.6f;
                    e.Status = true;         
                    Console.WriteLine(e.ID+"  "+e.NAME+"  "+e.PERCENTAGE +" "+e.Status);
                }
            }
        }

