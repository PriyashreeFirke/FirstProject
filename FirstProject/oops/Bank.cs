using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class Bank
    {
        long accountnumber;
        string customername;
        int balance;
        
        int total;
        

        public void Accept(long accountnumber, string customername, int balance)
        {
            this.accountnumber = accountnumber;
            this.customername = customername;
            this.balance = balance;
        }
        public void Display()
        {
            Console.WriteLine("account number" + accountnumber);
            Console.WriteLine("customer name" + customername);
            Console.WriteLine("balance" + balance);
            
        }
        public void Amountwithdraw()
        {
            Console.WriteLine("Enter withdrawamount");
            int withdrawamount = int.Parse(Console.ReadLine());
            if (balance <= withdrawamount)
            {
                Console.WriteLine("error");
            }
            else
            {
                total = balance - withdrawamount;
                Console.WriteLine(" withdraw successful total "+ total);
            }
           // this.Deposit();
            
        }
        public void Deposit()
        {
            Console.WriteLine("enter deposite amount");
            int depositamount=int.Parse(Console.ReadLine());
            
            total = balance + depositamount;
            Console.WriteLine("Total "+ total);
        }
        static void Main(string[] args)
        {
            Bank s = new Bank();
            s.Accept(6178996, "anu", 5000);
            s.Display();
            s.Amountwithdraw();
            s.Deposit();
        }
    }
    
       

}
