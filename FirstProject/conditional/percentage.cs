using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class percentage
    {
        static void Main(string[] args)

        {
            int total, percentage,average;
            Console.WriteLine("enter maths the marks");
            int maths = int.Parse(Console.ReadLine());
            Console.WriteLine("enter  art the marks");
            int art = int.Parse(Console.ReadLine());
            Console.WriteLine("enter History the marks");
            int History = int.Parse(Console.ReadLine());
            Console.WriteLine("enter science the marks");
            int science = int.Parse(Console.ReadLine());
            Console.WriteLine("enter hindi the marks");
            int Hindi = int.Parse(Console.ReadLine());
            

            total = maths + art + History + science + Hindi;
            Console.WriteLine("total" + total);
            percentage = (total * 100) / 500;
            Console.WriteLine("percentage" + percentage);
            average = maths + art + History + science + Hindi / 5;
            Console.WriteLine("average" + average);
            if (percentage > 70)
            {
                Console.WriteLine("distinction");
            }
            else if (percentage >= 60 && percentage <= 70)

            {
                Console.WriteLine("first class");
            }
            else if (percentage >= 50 && percentage <= 60)
            {
                Console.WriteLine("second class");
            }
            else if (percentage >= 35 && percentage <= 50)
            {
                Console.WriteLine("pass");
            
            }
            else
            {
                Console.WriteLine("fail");
            }

        }
    }
}
