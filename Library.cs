using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class category
    {
        string study;
        string comics;
        string poetry;

    }
    class Book
    {
        int bookid; string book_name;
        string author; int noofcopies;
        int publication; int price;
        category c;

        public Book()
        {

        }

        public Book(int bookid, string book_name, string author, int noofcopies, int publication, int price, category c)
        {
            this.bookid = bookid;
            this.book_name = book_name;
            this.author = author;
            this.noofcopies = noofcopies;
            this.publication = publication;
            this.price = price;
            this.c = c;
        }

        public int Bookid { get => bookid; set => bookid = value; }
        public string Book_name { get => book_name; set => book_name = value; }
        public string Author { get => author; set => author = value; }
        public int Noofcopies { get => noofcopies; set => noofcopies = value; }
        public int Publication { get => publication; set => publication = value; }
        public int Price { get => price; set => price = value; }
        internal category C { get => c; set => c = value; }


        public override string ToString()
        {
            return $"Bookid:{Bookid} Bookname:{book_name} author :{author} noofcpoies:{noofcopies} publication :{publication} price:{price}";
        }

    } 
}

class Member
{
    int memberid;
    string membername;
    string email;
    string password;
    int mobile;
    string address;

    public Member()
    {

    }

  
    public Member(int memberid, string membername, string email, int mobile, string adr)
    {
        this.memberid = memberid;
        this.membername = membername;
        this.email = email;
        this.password = password;
        this.mobile = mobile;
        this.address = address;
    }

    public int Memberid { get => memberid; set => memberid = value; }
    public string Membername { get => membername; set => membername = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => password;set=>password = value; }
    public int Mobile { get => mobile; set => mobile = value; }
    public string Address{ get => address; set => address = value; }


    public override string ToString()
    {
        return $"memberid:{memberid} membername:{membername} Email :{email} mobile:{mobile} address:{address}";
    }
}

class Transaction
{
    int transactionid;
    int issuedate;
    int returnDate;
    
    public Transaction()
    {

    }

    public Transaction(int transactionid, int issuedate, int returnDate, List<string> book)
    {
        this.transactionid = transactionid;
        this.issuedate = issuedate;
        this.returnDate = returnDate;
        
    }

    public int Transactionid { get => transactionid; set => transactionid = value; }
    public int Issuedate { get => issuedate; set => issuedate = value; }
    public int ReturnDate { get => returnDate; set => returnDate = value; }
    

    public override string ToString()
    {
       // return $"transactionid:{transactionid} issuedate:{issuedate} returndate :{returnDate} book:{book}";
    }
}
class Library
{
    string address;
    string libraryname;
    

    public Library()
        {
         }

    public Library(string address, string libraryname, List<string> book, List<string> member)
    {
        this.address = address;
        this.libraryname = libraryname;
        
    }

    public string Address { get => address; set => address = value; }
    public string Libraryname { get => libraryname; set => libraryname = value; }
    
    public override string ToString()
    {
        return $"address:{address} libraryname:{libraryname} book :{Book} member:{Member}";
    }
}

