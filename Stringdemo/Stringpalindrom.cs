using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Stringpalindrom
    {

        static bool Ispalindrom(string mystr)
        {
            bool palindrom = true;
            for (int i = 0; i < mystr.Length; i++)
            {
                if (mystr[i] != mystr[mystr.Length - i - 1])
                {
                    palindrom = false;
                    break;
                }
            }
            return palindrom;
        }
        static void Main(string[] args)
        {
            string s = "madam";
            if (Ispalindrom(s) == true)
            {
                Console.WriteLine(s + "is palindrom");

            }
            else
            {
                Console.WriteLine(s + "is not palindrom");
            }
        }

    }
}
 
           
        
        
        

       