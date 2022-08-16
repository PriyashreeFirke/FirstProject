using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.exam5
{
    
        class person
        {
            internal string name = "ria";
            public void Showperson()
            {
                Console.WriteLine("Name=" + name);
            }
        }
        class principle : person
        {
            internal string gender = "Female";
            public void showP()
            {
                Console.WriteLine(name + " " + gender);
            }
        }
        class teacher : principle
        {
            int salary = 40000;
            public void showT()
            {
                Console.WriteLine(name + " " + gender + " " + salary);
            }
        }
        class Multi3
        {
            static void Main(string[] args)
            {
                teacher t = new teacher();
                t.showT();
                t.showP();

            }
        }

    }

