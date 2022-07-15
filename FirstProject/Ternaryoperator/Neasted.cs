using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Ternaryoperator
{
    class Neasted
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("input first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is largest");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is largest");
            }
            else
            {
                Console.WriteLine("num3 is largest");

            }



        }
    }
}
            /* if (num1 > num2)
             {
                 if (num1 > num3)
                 {
                     Console.WriteLine("first number is greter");
                 }
                 else
                 {
                     Console.WriteLine("third number is greter");
                 }
             }
             else if (num2 > num3)
                 Console.WriteLine("number 2 is greter");
             else
                 Console.WriteLine("number three is greter");
         } */
            //string ans = num1 > num2  ? "num1 is greter" : num2 > num3 ? " num2 is greter" : "num3 is greter";
            // Console.WriteLine("ans"  + ans);


           // string ans = num1 > num2 && num1 > num3 ? "num1 is greter" : num2 > num3 ? " num2 is greter" : "num3 is greter "; 
           // Console.WriteLine("ans"    + ans);
        
    
   
                        
                        

            
        
    


