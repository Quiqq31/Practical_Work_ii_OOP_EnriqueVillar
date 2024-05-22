using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Work_2_Enrique
{
    public partial class RecuperarPassword : Form
    {
        private string nuevapassword1;
        private string nuevapassword_Rep;

        private string nombre_verificar;

        private bool passwd_Confirmada;

        private List<Usuario> cuentas = new List<Usuario>();

        private States state = new States();

        public RecuperarPassword(States states)
        {
            this.state = states;
            CargarDeFichero();


            InitializeComponent();
            CenterToScreen();
        }

        private void btn_confirm_pas_Click(object sender, EventArgs e)
        {
            this.nuevapassword1 = textbox_passwd1.Text;
            this.nuevapassword_Rep = textbox_passwd_rep.Text;
            this.nombre_verificar = textbox_user.Text;

            bool correctPasswd = false;
            if(textbox_passwd1.Text == "" || textbox_user.Text == "" || textbox_passwd_rep.Text == "")
            {
                MessageBox.Show("No emplty fields please.");
                return;
            }
            else
            {
                if (this.nuevapassword1 == textbox_passwd_rep.Text) // comprobamos que las contraseñas sean iguales
                {
                    correctPasswd = VerificarPasswd(this.nuevapassword1, this.nuevapassword_Rep);
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please try again.");
                    return;
                }

                if (correctPasswd == true)
                {
                    foreach(Usuario user in cuentas)
                    {
                        if (this.nombre_verificar == user.GetName())
                        {
                            user.SetPassword(this.nuevapassword1);
                            this.passwd_Confirmada = true;
                        }
                    }

                    if (passwd_Confirmada == true) // he cambiado la contraseña para el objeto usuario correspondiente, ahora hay que actualizar la lista
                    {
                        this.state.ChangeForm(1);
                        this.Close();
                    }
                }
            }
        }

        public bool VerificarPasswd(string NewPassword1, string NewPassword2)
        {
            if (NewPassword1.Length >= 8) // comprobamos la longitud de la contraseña, minimo 8 caracteres
            {

                int i = 0;
                int numero = 0;
                int mayuscula = 0;
                int minuscula = 0;
                int simbolo = 0;
                foreach (char c in NewPassword1) // comprobamos que la contraseña tenga al menos un numero, una letra mayuscula, una minuscula y un caracter especial
                {
                    if (char.IsDigit(c) || char.IsUpper(c) || char.IsLower(c) || char.IsSymbol(c)) // si se cumple alguna de la condiciones
                    {
                        i++;
                        if (char.IsDigit(c))
                        {
                            numero++;
                        }
                        else if (char.IsUpper(c))
                        {
                            mayuscula++;
                        }
                        else if (char.IsLower(c))
                        {
                            minuscula++;
                        }
                        else if (char.IsSymbol(c))
                        {
                            simbolo++;
                        }
                    }


                    if (i >= 8) // si se cumplen las 4 condiciones
                    {
                        if (numero >= 1 && mayuscula >= 1 && minuscula >= 1 && simbolo >= 1) // si se cumplen las 4 condiciones
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Password must contain at least one number, one uppercase letter, one lowercase letter and one special character. Please try again.");
                            return false;
                        }
                    }
                }

                MessageBox.Show("Password valid.");
                return true;
            }
            return false;
        }

        public void CargarDeFichero()
        {
            string path = "users.txt";

            StreamReader sr = new StreamReader(path);

            string linea = "";

            while ((linea = sr.ReadLine()) != null)
            {
                string[] palabras = linea.Split(';');

                Usuario usr = new Usuario(palabras[0], palabras[1], palabras[2], palabras[3]);
                this.cuentas.Add(usr);
            }
        }
    }
}
