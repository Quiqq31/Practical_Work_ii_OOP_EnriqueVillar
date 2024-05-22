using System;
using System.Collections;

namespace Practical_Work_2_Enrique
{
    public class Power : Operation
    {
        public Power()
        {

        }

        public string Elevar(int op1, int op2)
        {
            int result = op1;
            if (op2 == 0) return "1";

            for (int i = 1; i < op2; i++)
            {
                result = result * op1;
            }
            return Convert.ToString(result);
        }
    }
}
