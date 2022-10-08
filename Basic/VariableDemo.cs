using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Basic
{
    class VariableDemo
    {
        static void Main(string[] args)
        { 
            byte mybyte= 56;//1byte 8 bit
            sbyte mybyte2 = -45;//8bit 7 bit value 1 bit for sign

            Console.WriteLine(mybyte + "" + mybyte2);

            short my_shortvalue = 234;//2 byte //32,768 to -32,768
            short my_shortvalue1 = -786;

            int my_intvalue = 45667;//4byte//2^-31
            int myvale1 = -90877;

            long myLong = 9878999977;//8 byte//2^64 to 26-64
            long mylong2 = -09876789;

            double mydouble = 89.67;//8 byte

            float myfloat = 67.78f;//4 byte

            char ch='y';
            char ch1 = '*';

            bool isvalue = true;


        }

    }
}
