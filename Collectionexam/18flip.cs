using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{

    class order
    {
        int orderid;
        string city;
        string itemname;
        string status;

        public order()
        {

        }
        public order(int orderid, string city, string itemname, string status)
        {
            this.Orderid = orderid;
            this.City = city;
            this.Itemname = itemname;
            this.Status = status;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string City { get => city; set => city = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public string Status { get => status; set => status = value; }
    }

    
    class flip
    {
        static void Main(string[] args)
        {
            List<order> lst = new List<order>();
            lst.Add(new order(1, "pune", "laptop", "pending"));
            lst.Add(new order(2, "bsp", "mobile", "deliverd"));
            lst.Add(new order(3, "bhopal", "laptop", "pending"));
            lst.Add(new order(4, "indor", "tab", "pending"));

            SortedList<string, int> ss = new SortedList<string, int>();
            foreach(order or in lst)
            {
                string city = or.City;
                string status = or.Status;
                if(status=="pending")
                {
                    if(ss.ContainsKey(city))
                    {
                        int val = ss[city];
                        ss[city] = val + 1;
                    }
                    else
                    {
                        ss.Add(city, 1);
                    }
                }
            }
        }
    }
}
