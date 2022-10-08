using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.xobine
{
    class average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter digit");
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            float avg, sum = 0;
            
                while(n>0)
                {
                    int r = n % 10;

                sum = sum + r;
                    n = n / 10;
                    
                    c++;
                    
                }
            avg =(float) sum / c;
            Console.WriteLine(avg);
                
                
                

            }
        }
    }

