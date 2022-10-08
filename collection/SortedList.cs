using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class SortBookByprice :IComparer<Book1>
    {
        public int Compare(Book1 x,Book1 y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }

    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<Book1, int> ss = new SortedList<Book1, int>(new SortBookByprice());
            ss.Add(new Book1("english", 600, "abc"),30);
            ss.Add(new Book1("hindi", 800, "guru"),76);
            ss.Add(new Book1("maths", 400, "xyz"),23);
            foreach(KeyValuePair<Book1,int> kv in ss)
                Console.WriteLine(kv.Key+""+kv.Value);


        }
    }
    internal class Book1 : IComparable<Book1>
    {
        string BookName;
        int price;
        string authorName;

        public Book1(string bookName, int price, string authorName)
        {
            BookName1 = bookName;
            this.Price = price;
            this.AuthorName = authorName;
        }
        public override string ToString()
        {
            return "BookName:" + BookName + "authorname" + AuthorName + "price:" + price;
        }

        public string BookName1 { get => BookName; set => BookName = value; }
        public int Price { get => price; set => price = value; }
        public string AuthorName { get => authorName; set => authorName = value; }

        public int CompareTo(Book1 b2)
        {
            return b2.BookName1.CompareTo(this.BookName1);
        }
}
    
}
