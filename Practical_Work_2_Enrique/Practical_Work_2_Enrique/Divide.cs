using System;
using System.Collections;

namespace Practical_Work_2_Enrique
{
    public class Divide : Operation
    {
        public Divide()
        {

        }

        public string Dividir(double op1, double op2)
        {
            try
            {
                return Convert.ToString(op1 / op2);
            }
            catch (DivideByZeroException)
            {
                return "ERROR Calculo (No Dividir entre 0)";
            }
        }

        public string Dividir(string signo, double op1, double op2)
        {
            try
            {
                signo += op1 / op2;

                return signo;
            }
            catch (DivideByZeroException)
            {
                return "ERROR Calculo (No Dividir entre 0)";
            }
        }
    }
}
