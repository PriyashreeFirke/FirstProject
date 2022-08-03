using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam3
{
    class Classorder
    {
        int order_id;
        string city;
        string name;
        bool isdeliverd;
        public int Order
        {
            get { return order_id; }
            set { order_id = value; }
        }
        public string CITY
        {
            get { return city; }
            set { city = value; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
       
        public bool Status
        {

            get { return isdeliverd; }
            set { isdeliverd = value; }
        }
    }
    class classinfo
    {
        static void Main(string[] args)
        {
            Classorder c = new Classorder();
            c.Order = 101;
            c.CITY= "PUNE";
            c.NAME = "Ria";
            c.Status = true;
            Console.WriteLine(c.Order);
            Console.WriteLine(c.CITY);
            Console.WriteLine(c.NAME);
            Console.WriteLine(c.Status);
            

        }
    }
}
