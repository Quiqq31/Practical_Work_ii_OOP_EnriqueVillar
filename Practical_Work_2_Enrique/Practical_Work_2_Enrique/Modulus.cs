using System;
using System.Collections;

namespace Practical_Work_2_Enrique
{
    internal class Modulus : Operation
    {
        public Modulus()
        {

        }

        public string Modulo(int op1, int op2)
        {
            if (op1 == 0 || op2 == 1) return "0";

            int dividend = Math.Abs(op1);
            int divisor = Math.Abs(op2);

            while (dividend > divisor)
            {
                dividend -= divisor;
            }
            return Convert.ToString(dividend);
        }

    }
}
