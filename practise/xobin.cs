using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.practise
{
    class xobin
    {
        int cost_price;
        int no_of_item;
        int profit;
        public void SellingPrice(int cs, int noi, int p)
        {
            cost_price =cs;
            no_of_item = noi;
            profit =  p;
        }
        public float calculate_selling_price()
        {  
                float sp= (100+profit)/100 *cost_price;
            
            return (float)sp;
           
        }
        static void Main(string[] args)
        {
            xobin x = new xobin();
            x.SellingPrice(15, 10,20);
            float sp=x.calculate_selling_price();
            Console.WriteLine("selling price ="+sp);
           
        }
    }
}

                

            
