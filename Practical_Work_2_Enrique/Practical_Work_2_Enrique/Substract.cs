using System;
using System.Collections;

namespace Practical_Work_2_Enrique
{
    public class Substract : Operation
    {
        public Substract()
        {
        }

        public string Restar(double op1, double op2)
        {
            return Convert.ToString(op1 - op2);
        }
        public string Restar(string signo, double op1, double op2)
        {
            signo += op1 - op2;
            return signo;
        }

    }
}
