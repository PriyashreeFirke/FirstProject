using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class Shopping
    {
        string item;
         int quantity;
         int price;
         int total_bill;

        public void Accept(string item, int quantity, int price)
        {
            this.item = item;
            this.quantity = quantity;
            this.price = price;

            if (this.quantity <= 0)
            {
                Console.WriteLine("error");

            }
            else 
            {
                total_bill = this.Getbill();
                this.Display();
            }
        }public int Getbill( ) 
        {
             return price*quantity;
            
        }
        public void Display()
        {
            Console.WriteLine("item" + item);
            Console.WriteLine("quantity"+ quantity);
            Console.WriteLine("price"+ price);
            Console.WriteLine("Total Bill"+total_bill);
                
        }
        static void Main(string[] args)
        {
            Shopping obj = new Shopping();
            obj.Accept("shirt", 6, 850);
            obj.Display();
            //obj.Getbill();
            

        }

    }
}
