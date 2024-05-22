using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Practical_Work_2_Enrique
{
    public partial class Calculator : Form
    {
        States state = new States();

        public Calculator(States states)
        {
            this.state = states;

            InitializeComponent();
            CenterToScreen();
        }

        private void button_del_click(object sender, EventArgs e)
        {
            // Lógica para el botón DELETE
            txtbox_sol.Text = "";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            try
            {
                Operation op = new Operation(txtbox_sol.Text);
                op.ProcesarOp();
                txtbox_sol.Text = op.PrintSolucion();

            }
            catch (Exception ex)
            {
                // Manejo de errores
                txtbox_sol.Text = "Error X";
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            // Lógica para el botón DIVISION
            txtbox_sol.Text += " / ";
        }

        private void btn_multip_Click(object sender, EventArgs e)
        {
            // Lógica para el botón MULTIPLICACION
            txtbox_sol.Text += " * ";
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            // Lógica para el botón MOD
            txtbox_sol.Text += " mod ";
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            // Lógica para el botón RESTA
            txtbox_sol.Text += " - ";
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            // Lógica para el botón POW
            txtbox_sol.Text += " ^ ";
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            // Lógica para el botón SUMA
            txtbox_sol.Text += " + ";
        }

        // BOTONES DE NUMEROS 

        private void button0_Click(object sender, EventArgs e)
        {
 
            txtbox_sol.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "9";
        }

        private void buttonSR_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += "-";
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            txtbox_sol.Text += ",";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.state.ChangeForm(0); 
            this.Close();
        }
    }
}
