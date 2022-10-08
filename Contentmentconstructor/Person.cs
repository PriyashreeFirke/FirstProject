using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Contentment
{

    class Address
    {
        int pincode;
        string city;

        public Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void ShowAddress()
        {
            Console.WriteLine(" "+pincode+" "+city);
        }

    }
    class Person
    {
        int id;
        string name;
        Address adr;

        Person(int id, string name, Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }
        void DisplayPerson()
        {
            Console.WriteLine(id+" "+name);
            adr.ShowAddress();
        }
        static void Main(string[] args)
        {
            Address a = new Address( 234,"pune");
            Person p;
            p = new Person(1, "yash", a);
            p.DisplayPerson();
        }



    }
}
