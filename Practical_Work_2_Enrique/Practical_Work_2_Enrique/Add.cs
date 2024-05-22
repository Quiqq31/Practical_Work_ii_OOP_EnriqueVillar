using System;
using System.Collections;

namespace Practical_Work_2_Enrique
{
    public class Add : Operation
    {
        public Add()
        {

        }

        public string Sumar(double op1, double op2)
        {
            return Convert.ToString(op1 + op2);
        }
        public string Sumar(string signo, double op1, double op2)
        {
            signo += op1 + op2;
            return signo + op1 + op2;
        }
    }
}
