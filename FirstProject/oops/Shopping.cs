using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class Shopping
    {
        public string item;
        public int quantity;
        public int price;

        public void Accept(string sitem, int squantity, int sprice)
        {
            item = sitem;
            quantity = squantity;
            price = sprice;
            
            if (quantity <= 0)
            {
                Console.WriteLine("error"); 
                
            }
        }public void Getbill( ) 
        {
            Console.WriteLine("Total:   "+price*quantity);
            
        }
        public void summary()
        {
            Console.WriteLine("Summary:" + "1.Item  " + item + "\n" + "        2.Quantity " + quantity + "\n" + "        3.Price " + price);
        }
        static void Main(string[] args)
        {
            Shopping obj = new Shopping();
            obj.Accept("3", 6, 850);
            obj.summary();
            obj.Getbill();

        }

    }
}
