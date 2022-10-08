using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.oops
{
    class MethodDemo
    {
        //accessmodifier return type methodname()
        //{
        //logic
        //}


        // no retrun type no parameter

        public void Show()//method defination or method body
        {
            Console.WriteLine("show method");
        }
        // no return type with parameter

        public void addition(int x, float y)
        {
            float result = x + y;
            Console.WriteLine("Result" + result);

        }
        //with return type no parameter
        public int AreaRectangle()
        {
            int a = 5 * 4;
            return a;
        }
        //with return type with parameter
        public float Areaofcircle(int r)
        {
            {
                float PI = 3.14f;
                return (PI * r * r);
            }
        }

            class Demo
        {
            static void Main(string[] args)
            {
                {
                    MethodDemo d = new MethodDemo();
                    d.Show();//Method calling
                    d.addition(5, 8.9f);
                }
            }
        }


    }
}
