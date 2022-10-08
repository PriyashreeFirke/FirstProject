using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class Trainner : IComparable<Trainner>
    {
        string name;
        int id;
        int salary;

        public int CompareTo(Trainner b2)
        {
            return this.Name.CompareTo(b2.Name);
        }
        public Trainner(string name, int id, int salary)
        {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
        }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"name:{Name} id:{Id} salary :{Salary}";
        }
    }
    class Traineerdemo
    {
        static void Main(string[] args)
        {
            List<Trainner> lst = new List<Trainner>();
            lst.Add(new Trainner("deepamam", 101, 45000));
            lst.Add(new Trainner("medhamam", 102, 55000));
            lst.Sort();
            foreach (Trainner b in lst)
            {

                Console.WriteLine(b);
            }
        }
    }

        

}
