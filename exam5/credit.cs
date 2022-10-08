using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam5
{
    class shoppoiing
    {
        string d="debit card" ;
        char e = 'd';
        public void  Dotransaction(string a)
        {
            Console.WriteLine("you got 15% discount on bill on credit transaction");
        }
        public void Dotransaction( char d)
        {

            Console.WriteLine("No discount on bill on debit card transaction");
        }
    }
    class credit
    {
        static void Main(string[] args)
        {


            shoppoiing c = new shoppoiing();
            c.Dotransaction("credit card");
            c.Dotransaction( 'e');

        }
    }
}
