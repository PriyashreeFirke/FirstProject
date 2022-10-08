using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Overloading
{
    class Loan
    {
        float principal_amount;
        float rate_of_intrest;
        int days;
        float intrest;
        float intrest2;
        int Calculate_loan(float principal_amount,float rate_of_intrest,int days)
        {
            intrest = principal_amount * rate_of_intrest * days / 100;
            return (int) intrest;
        }
        float Calculate_loan(int principal_amount, float rate_of_intrest1, float rate_of_intrest2, int days)
        {
            if (days >= 183)
            {
                intrest2 = principal_amount * rate_of_intrest * days / 100;
            }
            else
            {
                intrest2 = principal_amount * rate_of_intrest2 * days / 100;
            }
            return (int)intrest2;
        }
        static void Main(string[] args)
        {
            Loan l = new Loan();
            l.Calculate_loan(20000, 0.5f, 365);
            l.Calculate_loan(10000, 0.6f, 0.4f, 365);

        }
    }
}
