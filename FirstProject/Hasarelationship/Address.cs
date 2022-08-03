using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Hasarelationship
{
    class Address
    {
        int pincode;
        string city;

        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

    }
    class person
    {
        int id;
        string name;
        Address adr;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Address Adr
        {
            get { return adr; }
            set { adr = value; }
        }

    }
    class AddressInfo
    {

        static void Main(string[] args)
        {
            person p = new person();
            p.Id = 101;
            p.Name = "priya";
            p.Adr = new Address();
            p.Adr.Pincode = 411057;
            p.Adr.City = "pune";
            Console.WriteLine(p.Id + " " + p.Name + " " + p.Adr.Pincode + " " + p.Adr.City);
        }


    }
}
