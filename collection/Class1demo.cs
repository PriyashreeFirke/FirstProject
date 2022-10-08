using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class Book:IComparable<Book>
    {
        string bookname;
        int price;
        string authorname;

        public int CompareTo(Book b2)
        {
            /* if(this.price < b2.price)
              return -1;
            else if(this.price> b2.price)
            return 1;
            else
            return 0;*/

           // return this.price.CompareTo(b2.Price);
           if(this.price==b2.price)// if same price is there so we will check by authorname
            {
                return this.Authorname.CompareTo(b2.Authorname);
            }
            return this.price.CompareTo(b2.price);//ascending order
           // return b2.price.CompareTo(this.price);//decending order
        }

        public Book(string bookname, int price, string authorname)
        {
            this.Bookname = bookname;
            this.Price = price;
            this.Authorname = authorname;
        }

        public string Bookname { get => bookname; set => bookname = value; }
        public int Price { get => price; set => price = value; }
        public string Authorname { get => authorname; set => authorname = value; }

        public override string ToString()
        {
            
              
                return $"Bookname:{bookname} AuthorName:{authorname} price :{Price}";
            
        }
    }
    class Class1demo
    {
        static void Main(string[] args)
        {
            List<Book> lst = new List<Book>();
            lst.Add(new Book("c#", 900, "kathy"));
            lst.Add(new Book("java", 500, "ramesh"));
            lst.Add(new Book("python", 800, "balaguru"));
            lst.Add(new Book("c", 300, "kanetkar"));
            lst.Sort();
            foreach (Book b in lst)
            {
                if (b.Price > 300)
                    b.Price = b.Price + 100;
                Console.WriteLine(b);
            }
        }
    }
}
