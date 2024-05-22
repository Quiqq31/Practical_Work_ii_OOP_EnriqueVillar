using System;
using System.Collections;

namespace Practical_Work_2_Enrique
{
    public class Operation
    {
        protected string operation;
        protected string operand;
        protected double op1;
        protected double op2;

        protected int numero1;
        protected int numero2;

        protected string resultado;

        private string signo;

        public Operation(string operation)
        {
            this.operation = operation;
        }

        public Operation() // Constructor vacio
        {

        }

        public void ProcesarOp()
        {
            string[] elementos = this.operation.Split(' ');

            this.op1 = Convert.ToDouble(elementos[0]); // primer numero de la operacion
            this.operand = elementos[1]; // symbolo de operacion
            this.op2 = Convert.ToDouble(elementos[2]); // segundo numero de la operacion

            this.numero1 = Convert.ToInt32(elementos[0]);
            this.numero2 = Convert.ToInt32(elementos[2]);

            if (elementos.Length == 4) 
            {
                this.signo = elementos[0];
                this.op1 = Convert.ToDouble(elementos[1]); // primer numero de la operacion
                this.operand = elementos[2]; // symbolo de operacion
                this.op2 = Convert.ToDouble(elementos[3]); // segundo numero de la operacion

                this.numero1 = Convert.ToInt32(elementos[1]);
                this.numero2 = Convert.ToInt32(elementos[3]);

                switch (this.operand)
                {
                    case "+":
                        Add suma = new Add();
                        this.resultado = suma.Sumar(this.op1, this.op2);
                        break;
                    case "-":
                        Substract resta = new Substract();
                        this.resultado = resta.Restar(this.op1, this.op2);
                        break;
                    case "*":
                        Multiply mult = new Multiply();
                        this.resultado = mult.Multiplicar(this.op1, this.op2);
                        break;
                    case "/":
                        Divide div = new Divide();
                        this.resultado = div.Dividir(this.op1, this.op2);
                        break;
                    case "mod":
                        if (!this.operation.Contains(',')) // si no es double
                        {
                            Modulus modul = new Modulus();
                            this.resultado = modul.Modulo(this.numero1, this.numero2);
                        }
                        break;
                    case "^":
                        if (!this.operation.Contains(',')) // si no es double
                        {
                            Power power = new Power();
                            this.resultado = power.Elevar(this.numero1, this.numero2);
                        }
                        break;
                }
            }

            switch (this.operand)
            {
                case "+":
                    Add suma = new Add();
                    this.resultado = suma.Sumar(this.op1, this.op2);
                    break;
                case "-":
                    Substract resta = new Substract();
                    this.resultado = resta.Restar(this.op1, this.op2);
                    break;
                case "*":
                    Multiply mult = new Multiply();
                    this.resultado = mult.Multiplicar(this.op1, this.op2);
                    break;
                case "/":
                    Divide div = new Divide();
                    this.resultado = div.Dividir(this.op1, this.op2);
                    break;
                case "mod":
                    if (!this.operation.Contains(',')) // si no es double
                    {
                        Modulus modul = new Modulus();
                        this.resultado = modul.Modulo(this.numero1, this.numero2);
                    }
                    break;
                case "^":
                    if (!this.operation.Contains(',')) // si no es double
                    {
                        Power power = new Power();
                        this.resultado = power.Elevar(this.numero1, this.numero2);
                    }
                    break;
            }
        }

        public string PrintSolucion()
        {
            return Convert.ToString(this.resultado);
        }
    }
}


