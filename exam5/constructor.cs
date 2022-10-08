using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam5
{
    class This
    {
        public This(int a, double b, string c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }

            
            public This(int a, int b) : this(50, 2.9, "Hello")
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }

        
        class constructor
        {
            static public void Main()
        {
           This obj = new This(15, 30);
            }
        }
    }

